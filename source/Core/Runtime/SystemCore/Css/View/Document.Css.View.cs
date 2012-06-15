//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents a document node.
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// Gets the element at the specified coordinates in the viewport.
        /// </summary>
        /// <param name="x">The x-coordinate.</param>
        /// <param name="y">The y-coordinate.</param>
        /// <returns>An element.</returns>
        public Element elementFromPoint(int x, int y) { return null; }
    }
}