//----------------------------------------------
// Supported browser objects.
//----------------------------------------------

namespace System.Browser
{
    /// <summary>
    /// The definition for the browser navigator object.
    /// </summary>
    public partial interface Navigator
    {
        /// <summary>
        /// Gets the name of the browser.
        /// </summary>
        [ScriptField]
        string appName { get; }

        /// <summary>
        /// Gets the browser version information.
        /// </summary>
        [ScriptField]
        string appVersion { get; }

        /// <summary>
        /// Gets a value indicating whether or not cookies are enabled.
        /// </summary>
        [ScriptField]
        bool cookieEnabled { get; }

        /// <summary>
        /// Gets the current browser language.
        /// </summary>
        [ScriptField]
        string language { get; }

        /// <summary>
        /// Gets the name of the platform the browser is running on.
        /// </summary>
        [ScriptField]
        string platform { get; }

        /// <summary>
        /// Gets the user agent text.
        /// </summary>
        [ScriptField]
        string userAgent { get; }
    }
}