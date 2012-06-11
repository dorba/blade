using System;
using Roslyn.Compilers;

namespace Blade.Compiler
{
    /// <summary>
    /// Represents a compiler message.
    /// </summary>
    public class CompilationMessage
    {
        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the path to the error file.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the text location of the error.
        /// </summary>
        public DocumentLocation Location { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the error has a text location.
        /// </summary>
        public bool IsLocatable
        {
            get
            {
                return (!String.IsNullOrEmpty(FilePath) &&
                    Location.LineStart > -1 &&
                    Location.ColumnStart > -1 &&
                    Location.ColumnEnd > -1 &&
                    Location.LineEnd >= Location.LineStart);
            }
        }
    }
}