//----------------------------------------------
// Supported browser objects.
//----------------------------------------------

namespace System.Browser
{
    /// <summary>
    /// Represents the available ready state values.
    /// </summary>
    public enum ReadyState
    {
        /// <summary>
        /// <see cref="XMLHttpRequest"/>'s open method has not yet been called.
        /// </summary>
        UNSENT = 0,

        /// <summary>
        /// <see cref="XMLHttpRequest"/>'s send method has not yet been called.
        /// </summary>
        OPENED = 1,

        /// <summary>
        /// Headers and status are available.
        /// </summary>
        RECEIVED = 2,

        /// <summary>
        /// Download in progress.
        /// </summary>
        LOADING = 3,

        /// <summary>
        /// The operation is complete.
        /// </summary>
        DONE = 4
    }
}