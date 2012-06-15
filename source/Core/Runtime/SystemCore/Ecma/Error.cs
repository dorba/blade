//----------------------------------------------
// ECMA core object
//----------------------------------------------

namespace System
{
    /// <summary>
    /// Represents the ECMA Error object.
    /// </summary>
    public class Error : Exception
    {
        /// <summary>
        /// Creates a new error.
        /// </summary>
        public Error() { }

        /// <summary>
        /// Creates a new error with the specified message text.
        /// </summary>
        /// <param name="message">The error message.</param>
        public Error(object message) { }
    }
}