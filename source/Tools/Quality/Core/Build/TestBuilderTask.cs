using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Blade.Utilities.Interop;
using System.Text;

namespace Blade.Tools.Quality.Build
{
    /// <summary>
    /// An MSBUILD task that created an assembly for use with mstest.
    /// </summary>
    public class TestBuilderTask : AppDomainIsolatedTask
    {
        /// <summary>
        /// Gets or sets the project path.
        /// </summary>
        [Required]
        public string ProjectPath { get; set; }

        /// <summary>
        /// Gets or sets a list of source files, separated by semicolon.
        /// </summary>
        [Required]
        public string SourceList { get; set; }

        /// <summary>
        /// Gets or sets the assembly output path.
        /// </summary>
        [Required]
        public string OutputPath { get; set; }

        /// <summary>
        /// Gets or sets a list of references, separated by semicolon.
        /// </summary>
        [Required]
        public string References { get; set; }

        /// <summary>
        /// Gets or sets the target framework path.
        /// </summary>
        public string FrameworkPath { get; set; }

        /// <summary>
        /// Executes the build task.
        /// </summary>
        /// <returns></returns>
        public override bool Execute()
        {
            var projDir = Path.GetDirectoryName(ProjectPath);
            var sourceList = ParsePaths(SourceList, projDir);
            var builder = new TestAssemblyBuilder(sourceList);

            // preserve the generated blade assembly
            var bladeDllPath = Path.ChangeExtension(OutputPath, "client.dll");

            if (File.Exists(bladeDllPath))
                File.Delete(bladeDllPath);

            File.Move(OutputPath, bladeDllPath);

            // create the new output assembly for mstest to use
            builder.CreateAssembly(new TestAssemblyInfo
            {
                OutputPath = OutputPath,
                ProjectDir = projDir
            });

            // log any build warnings
            foreach (var item in builder.Warnings)
                Log.LogWarning(null, item.ErrorNumber, null, null, 0, 0, 0, 0, item.ErrorText);

            // log and stop on errors
            if (builder.HasErrors)
            {
                foreach (var item in builder.Errors)
                    Log.LogError(null, item.ErrorNumber, null, null, 0, 0, 0, 0, item.ErrorText);

                return false;
            }

            // build test script file
            WriteJsTestFile(bladeDllPath, Path.Combine(projDir, @"Web\scripts\test.js"),
                String.IsNullOrEmpty(FrameworkPath) ? null : new[] { FrameworkPath });

            // copy the required Blade Tools assembly
            DeployThisAssembly(Path.GetDirectoryName(OutputPath));

            return true;
        }

        #region Helper Methods

        private static IEnumerable<string> ParsePaths(string list, string dirPath = null)
        {
            return list.Split(';')
                .Where(p => !String.IsNullOrWhiteSpace(p))
                .Select(p => (String.IsNullOrWhiteSpace(dirPath) ||
                    Path.IsPathRooted(p)) ? p : (dirPath + "\\" + p));
        }

        private static void DeployThisAssembly(string outputDir)
        {
            var thisAsm = Assembly.GetExecutingAssembly();
            var thisAsmName = Path.GetFileName(thisAsm.Location);
            File.Copy(thisAsm.Location, Path.Combine(outputDir, thisAsmName), true);
        }

        private static void WriteJsTestFile(string bladeDllPath, string targetPath, IEnumerable<string> searchPaths)
        {
            if (!File.Exists(bladeDllPath))
                throw new FileNotFoundException("Unable to locate Blade unit test assembly.");

            if (File.Exists(targetPath))
                File.Delete(targetPath);

            // add any assembly search paths
            if (searchPaths != null)
            {
                foreach (var path in searchPaths)
                    ScriptDomain.CurrentDomain.AddSearchDirectory(path);
            }

            // load the unit test script assembly
            var assembly = ScriptAssembly.Load(bladeDllPath);
            var dependencies = assembly.GetDependencyChain();
            var newline = Encoding.UTF8.GetBytes(Environment.NewLine);

            // write all script into a single test file
            using (var stream = File.Create(targetPath))
            {
                // copy dependencies, in executable order
                foreach (var dep in dependencies.Reverse())
                {
                    if (dep.HasScriptResource)
                    {
                        dep.GetScriptResource().CopyTo(stream);
                        stream.Write(newline, 0, newline.Length);
                    }
                }

                // finally, copy the unit test script
                assembly.GetScriptResource().CopyTo(stream);
            }
        }

        #endregion
    }
}
