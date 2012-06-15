using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Blade.Compiler;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Blade.Build
{
    /// <summary>
    /// The entry point for the MSBuild blade target.
    /// </summary>
    public class BuildTask : AppDomainIsolatedTask
    {
        private CompilationService _service;

        /// <summary>
        /// Gets or sets the project path.
        /// </summary>
        [Required]
        public string ProjectPath { get; set; }

        /// <summary>
        /// Gets or sets the script file output path.
        /// </summary>
        [Required]
        public string ScriptPath { get; set; }

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
        /// Creates a new instance of the class.
        /// </summary>
        public BuildTask()
        {
            _service = new CompilationService();
        }

        /// <summary>
        /// Executes the task.
        /// </summary>
        /// <returns></returns>
        public override bool Execute()
        {
            var projDir = Path.GetDirectoryName(ProjectPath);
            var sourceList = ParsePaths(SourceFiles, projDir);
            var refList = ParsePaths(References);

            // compile the project
            var result = _service.CompileProject(ProjectPath, ScriptPath, sourceList, refList);

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

        private IEnumerable<string> ParsePaths(string list, string dirPath = null)
        {
            return list.Split(';')
                .Where(p => !String.IsNullOrWhiteSpace(p))
                .Select(p => (String.IsNullOrWhiteSpace(dirPath) ||
                    Path.IsPathRooted(p)) ? p : (dirPath + "\\" + p));
        }
    }
}