//----------------------------------------------
// Supported browser objects.
//----------------------------------------------

using System.Dom;

namespace System.Browser
{
    /// <summary>
    /// Represents the browser's XMLHttpRequest object.
    /// </summary>
    public sealed class XMLHttpRequest
    {
        /// <summary>
        /// Gets or sets a function that is called whenever the readyState attribute changes.
        /// </summary>
        [ScriptField]
        public IFunction onreadystatechange { get; set; }

        /// <summary>
        /// Gets the state of the request.
        /// </summary>
        [ScriptField]
        public ReadyState readyState { get; private set; }

        /// <summary>
        /// Gets the response as a DOM document.
        /// </summary>
        [ScriptField]
        public Document responseXML { get; private set; }

        /// <summary>
        /// Gets the response text.
        /// </summary>
        [ScriptField]
        public string responseText { get; private set; }

        /// <summary>
        /// Gets the HTTP result code.
        /// </summary>
        [ScriptField]
        public int status { get; private set; }

        /// <summary>
        /// Gets the response string.
        /// </summary>
        [ScriptField]
        public string statusText { get; private set; }

        /// <summary>
        /// Aborts the request if it has already been sent.
        /// </summary>
        public void abort()
        {
        }

        /// <summary>
        /// Gets all the response headers as a string, or null if no response has been received.
        /// </summary>
        /// <returns>The resulting string.</returns>
        public string getAllResponseHeaders()
        {
            return null;
        }

        /// <summary>
        /// Gets the string containing the text of the specified header, or null if either the
        /// response has not yet been received or the header doesn't exist in the response.
        /// </summary>
        /// <param name="name">The header name.</param>
        /// <returns>The resulting string.</returns>
        public string getResponseHeader(string name)
        {
            return null;
        }

        /// <summary>
        /// Initializes a request.
        /// </summary>
        /// <param name="method">The HTTP method to use, such as "GET", "POST", "PUT", "DELETE", etc.</param>
        /// <param name="url">The URL to which to send the request.</param>
        public void open(string method, string url)
        {
        }

        /// <summary>
        /// Initializes a request. 
        /// </summary>
        /// <param name="method">The HTTP method to use, such as "GET", "POST", "PUT", "DELETE", etc.</param>
        /// <param name="url">The URL to which to send the request.</param>
        /// <param name="isAsync">Indicates whether or not to perform the operation asynchronously.</param>
        public void open(string method, string url, bool isAsync)
        {
        }

        /// <summary>
        /// Initializes a request. 
        /// </summary>
        /// <param name="method">The HTTP method to use, such as "GET", "POST", "PUT", "DELETE", etc.</param>
        /// <param name="url">The URL to which to send the request.</param>
        /// <param name="isAsync">Indicates whether or not to perform the operation asynchronously.</param>
        /// <param name="user">A user name to use for authentication purposes.</param>
        /// <param name="password">A password to use for authentication purposes.</param>
        public void open(string method, string url, bool isAsync, string user, string password)
        {
        }

        /// <summary>
        /// Sends the request.
        /// </summary>
        public void send()
        {
        }

        /// <summary>
        /// Sends the request, with data.
        /// </summary>
        /// <param name="data">The data string.</param>
        public void send(string data)
        {
        }

        /// <summary>
        /// Sends the request, with data.
        /// </summary>
        /// <param name="data">A DOM document.</param>
        public void send(Document data)
        {
        }

        /// <summary>
        /// Sets the value of an HTTP request header.
        /// </summary>
        /// <param name="header">The name of the header whose value is to be set.</param>
        /// <param name="value">The value to set as the body of the header.</param>
        public void setRequestHeader(string header, string value)
        {
        }
    }
}