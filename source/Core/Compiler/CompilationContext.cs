using System.IO;
using Roslyn.Compilers.Common;

namespace Blade.Compiler
{
    /// <summary>
    /// The compilation context.
    /// </summary>
    internal class CompilationContext
    {
        /// <summary>
        /// Gets or sets the current compilation context.
        /// </summary>
        public static CompilationContext Current { get; set; }

        /// <summary>
        /// The compilation input object.
        /// </summary>
        public CompilationRequest Input { get; set; }

        /// <summary>
        /// The compilation object.
        /// </summary>
        public CommonCompilation Compilation { get; set; }

        /// <summary>
        /// The compilation result.
        /// </summary>
        public CompilationResult Result { get; set; }

        /// <summary>
        /// The generated compilation model.
        /// </summary>
        public CompilationModel Model { get; set; }

        /// <summary>
        /// Gets or sets the translation output stream.
        /// </summary>
        public Stream OutputStream { get; set; }
    }
}