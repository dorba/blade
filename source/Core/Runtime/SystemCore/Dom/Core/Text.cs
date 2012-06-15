//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Represents a text node.
	/// </summary>
    public abstract class Text : CharacterData
    {
		internal Text() { }

        /// <summary>
        /// Gets all contiguous text node values joined together, in order.
        /// </summary>
        public string wholeText { get; private set; }

		/// <summary>
		/// Splits the text node at the specified offset.
		/// </summary>
		/// <param name="offset">The index to split at.</param>
		/// <returns>The newly created node.</returns>
        public Text splitText(int offset) { return null; }
    }
}