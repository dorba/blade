using System.Collections.Generic;
using System.IO;

namespace Blade.Compiler
{
    /// <summary>
    /// Represents the input parameters for a compilation request.
    /// </summary>
    public class CompilationRequest
    {
        /// <summary>
        /// Gets or sets the target framework path.
        /// </summary>
        public string FrameworkPath { get; set; }

        /// <summary>
        /// Gets or sets the full paths to the source files.
        /// </summary>
        public IEnumerable<string> SourceFilePaths { get; set; }

        /// <summary>
        /// Gets or sets the full paths of the reference assemblies.
        /// </summary>
        public IEnumerable<string> ReferencePaths { get; set; }

        /// <summary>
        /// Gets or sets the preprocessor definitions.
        /// </summary>
        public IEnumerable<string> Definitions { get; set; }

        /// <summary>
        /// Gets or sets the directory of the output target.
        /// </summary>
        public string TargetDirectory { get; set; }

        /// <summary>
        /// Gets or sets the name of the output target.
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Gets the full target path without any extension.
        /// </summary>
        public string TargetPath
        {
            get { return Path.Combine(TargetDirectory, TargetName); }
        }
    }
}