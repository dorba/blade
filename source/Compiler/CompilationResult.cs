using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler
{
    /// <summary>
    /// Tracks the compilation state through all stages of the compiler.
    /// </summary>
    public class CompilationResult
    {
        private List<CompilationMessage> _errors;
        private List<CompilationMessage> _warnings;
        private const string BladeErrorPrefix = "Blade Compilation Error: ";
        private const string BladeWarningPrefix = "Blade Compilation Warning: ";

        /// <summary>
        /// Gets a value indicating if the compilation failed.
        /// </summary>
        public bool HasErrors
        {
            get { return Errors.Any(); }
        }

        /// <summary>
        /// Gets a value indicating if the compilation has warnings.
        /// </summary>
        public bool HasWarnings
        {
            get { return Warnings.Any(); }
        }

        /// <summary>
        /// Gets the compiler errors.
        /// </summary>
        public IEnumerable<CompilationMessage> Errors
        {
            get { return _errors; }
        }

        /// <summary>
        /// Gets the compiler warnings.
        /// </summary>
        public IEnumerable<CompilationMessage> Warnings
        {
            get { return _warnings; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public CompilationResult()
        {
            _errors = new List<CompilationMessage>();
            _warnings = new List<CompilationMessage>();
        }

        /// <summary>
        /// Adds an error, using the specified message.
        /// </summary>
        /// <param name="message">The error message text.</param>
        public void AddError(string message)
        {
            AddError(new CompilationMessage { Message = BladeErrorPrefix + message });
        }

        /// <summary>
        /// Adds an error, using the specified message.
        /// </summary>
        /// <param name="message">The error message.</param>
        public void AddError(CompilationMessage message)
        {
            _errors.Add(message);
        }


        /// <summary>
        /// Adds a warning, using the specified message.
        /// </summary>
        /// <param name="message">The warning message text.</param>
        public void AddWarning(string message)
        {
            AddWarning(new CompilationMessage { Message = BladeWarningPrefix + message });
        }

        /// <summary>
        /// Adds a warning, using the specified message.
        /// </summary>
        /// <param name="message">The warning message.</param>
        public void AddWarning(CompilationMessage message)
        {
            _warnings.Add(message);
        }

        /// <summary>
        /// Creates a result containing a single error.
        /// Should be used for non coding related errors.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <returns>A new compilation result.</returns>
        public static CompilationResult FatalError(string message)
        {
            var result = new CompilationResult();
            result.AddError("Fatal Error: " + message);

            return result;
        }
    }
}