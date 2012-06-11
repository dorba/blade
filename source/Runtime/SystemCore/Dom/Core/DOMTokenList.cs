//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents a set of space-separated tokens.
    /// </summary>
    public sealed class DOMTokenList
    {
        /// <summary>
        /// Gets the number of items in the list.
        /// </summary>
        [ScriptField]
        public int length { get; private set; }

        /// <summary>
        /// Gets an item in the list by index.
        /// </summary>
        /// <param name="index">The item index.</param>
        /// <returns>The token at the specified index.</returns>
        public string item(int index) { return null; }

        /// <summary>
        /// Gets a value indicating whether or not the list contains a token.
        /// </summary>
        /// <param name="token">The token to check for.</param>
        /// <returns>True if the token exists, false otherwise.</returns>
        bool contains(string token) { return false; }

        /// <summary>
        /// Adds a token to the list.
        /// </summary>
        /// <param name="token">The token to add.</param>
        void add(string token) { }

        /// <summary>
        /// Removes a token from the list.
        /// </summary>
        /// <param name="token">The token to remove.</param>
        void remove(string token) { }

        /// <summary>
        /// If the list contains the token, it is removed.
        /// Otherwise the token is added to the list.
        /// </summary>
        /// <param name="token">The token to toggle.</param>
        /// <returns>True if the token was added.</returns>
        bool toggle(string token) { return false; }
    }
}
