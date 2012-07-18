using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Blade.Compiler;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.Reflection;

namespace Blade.Build
{
    /// <summary>
    /// The entry point for the MSBuild blade target.
    /// </summary>
    public class ScriptGenerationTask : AppDomainIsolatedTask
    {
        private CompilationService _service;

        /// <summary>
        /// Gets or sets the target framework path.
        /// </summary>
        [Required]
        public string FrameworkPath { get; set; }

        /// <summary>
        /// Gets or sets the target output directory.
        /// </summary>
        [Required]
        public string TargetDir { get; set; }

        /// <summary>
        /// Gets or sets the name of the output target.
        /// </summary>
        [Required]
        public string TargetName { get; set; }

        /// <summary>
        /// Gets or sets a list of source files, separated by semicolon.
        /// </summary>
        [Required]
        public string SourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of references, separated by semicolon.
        /// </summary>
        [Required]
        public string References { get; set; }

        /// <summary>
        /// Gets or sets the preprocessor definitions.
        /// </summary>
        [Required]
        public string Definitions { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ScriptGenerationTask()
        {
            _service = new CompilationService();
        }

        /// <summary>
        /// Executes the task.
        /// </summary>
        /// <returns></returns>
        public override bool Execute()
        {
            //System.Diagnostics.Debugger.Launch();

            var sourceList = SourceFiles.Split(new[] { ';' },
                StringSplitOptions.RemoveEmptyEntries);

            var refList = ResolveReferences(References.Split(new[] { ';' },
                StringSplitOptions.RemoveEmptyEntries), FrameworkPath);

            // compile the project
            var result = _service.Compile(new CompilationRequest
            {
                FrameworkPath = FrameworkPath,
                TargetDirectory = TargetDir,
                TargetName = TargetName,
                SourceFilePaths = sourceList,
                ReferencePaths = refList,
                Definitions = Definitions.Split(';')
            });

            // check for compile warnings 
            if (result.HasWarnings)
            {
                foreach (var warn in result.Warnings)
                {
                    if (warn.IsLocatable)
                    {
                        Log.LogWarning(null, null, null, warn.FilePath,
                            warn.Location.LineStart, warn.Location.ColumnStart,
                            warn.Location.LineEnd, warn.Location.ColumnEnd,
                            warn.Message);
                    }
                    else Log.LogWarning(warn.Message);
                }
            }

            // check for compile errors
            if (result.HasErrors)
            {
                foreach (var err in result.Errors)
                {
                    if (err.IsLocatable)
                    {
                        Log.LogError(null, null, null, err.FilePath,
                            err.Location.LineStart, err.Location.ColumnStart,
                            err.Location.LineEnd, err.Location.ColumnEnd,
                            err.Message);
                    }
                    else Log.LogError(err.Message);
                }

                return false;
            }

            return true;
        }

        private static IEnumerable<string> ResolveReferences(IEnumerable<string> input, string frameworkDir)
        {
            foreach (var item in input)
            {
                if (String.IsNullOrWhiteSpace(item))
                    continue;

                if (!File.Exists(item))
                {
                    var fwRefPath = Path.Combine(frameworkDir, item);

                    if (!fwRefPath.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
                        fwRefPath += ".dll";

                    if (!File.Exists(fwRefPath))
                        throw new FileNotFoundException("Unable to locate assembly: " + item);
                    else yield return fwRefPath;
                }
                else yield return item;
            }

            if (!input.Any(p => p.IndexOf("mscorlib", StringComparison.OrdinalIgnoreCase) != -1))
                yield return Path.Combine(frameworkDir, "mscorlib.dll");

            if (!input.Any(p => p.IndexOf("System.Core", StringComparison.OrdinalIgnoreCase) != -1))
                yield return Path.Combine(frameworkDir, "System.Core.dll");
        }
    }
}