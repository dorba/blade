//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents a generic collection of elements.
    /// </summary>
    public abstract class HTMLCollection
    {
        internal HTMLCollection() { }

        /// <summary>
        /// Gets the number of items in the collection.
        /// </summary>
        [ScriptField]
        public int length { get; private set; }

        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The element at the specified index.</returns>
        public Element item(int index) { return null; }

        /// <summary>
        /// Gets the first element with the specified name or id value.
        /// </summary>
        /// <param name="name">The target name.</param>
        /// <returns></returns>
        public Element namedItem(string name) { return null; }
    }
}