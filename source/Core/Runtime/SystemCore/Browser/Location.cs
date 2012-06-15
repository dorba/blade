//----------------------------------------------
// Supported browser objects.
//----------------------------------------------

namespace System.Browser
{
    /// <summary>
    /// The definition for the browser location object.
    /// </summary>
    public partial interface Location
    {
        /// <summary>
        /// Gets or sets the URL hash value.
        /// </summary>
        [ScriptField]
        string hash { get; set; }

        /// <summary>
        /// Gets the hostname and port of the URL.
        /// </summary>
        [ScriptField]
        string host { get; }

        /// <summary>
        /// Gets the hostname of the URL.
        /// </summary>
        [ScriptField]
        string hostname { get; }

        /// <summary>
        /// Gets or sets the entire URL.
        /// </summary>
        [ScriptField]
        string href { get; set; }

        /// <summary>
        /// Gets or sets the root relative path or the URL.
        /// </summary>
        [ScriptField]
        string pathname { get; set; }

        /// <summary>
        /// Gets or sets the port of the URL.
        /// </summary>
        [ScriptField]
        string port { get; set; }

        /// <summary>
        /// Gets the protocol of the URL.
        /// </summary>
        [ScriptField]
        string protocol { get; }

        /// <summary>
        /// Gets or sets the query string of the URL.
        /// </summary>
        [ScriptField]
        string search { get; set; }

        /// <summary>
        /// Reloads the current document.
        /// </summary>
        void reload();

        /// <summary>
        /// Reloads the current document.
        /// </summary>
        /// <param name="force">True to force reload from the server.</param>
        void reload(bool force);

        /// <summary>
        /// Replaces the current document with a new one.
        /// </summary>
        /// <param name="url">The document URL.</param>
        void replace(string url);

        /// <summary>
        /// Load the document at the provided URL.
        /// </summary>
        /// <param name="url">The document URL.</param>
        void assign(string url);
    }
}