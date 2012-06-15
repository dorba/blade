
namespace System
{
    /// <summary>
    /// Exception base class, note that for Javascript the most
    /// basic exception class is Error. Custom exceptions should 
    /// derive from the Error class, instead of this one.
    /// </summary>
    [ScriptName("Error")]
    public abstract class Exception
    {
        /// <summary>
        /// Creates a new error.
        /// </summary>
        public Exception() { }

        /// <summary>
        /// Creates a new error with the specified message text.
        /// </summary>
        /// <param name="message">The error message.</param>
        public Exception(object message) { }
    }
}


