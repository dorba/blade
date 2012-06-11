//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------
using System.Css;

namespace System.Dom
{
    /// <summary>
    /// Represents a fragment of a document.
    /// </summary>
    public sealed partial class Range
    {
        /// <summary>
        /// Gets the bounding rectanges for this range.
        /// </summary>
        /// <returns>A collection of rectangles.</returns>
        public ClientRect[] getClientRects() { return null; }

        /// <summary>
        /// Gets the union of all bounding rectangles for this range.
        /// </summary>
        /// <returns>A single rectangle.</returns>
        public ClientRect getBoundingClientRect() { return null; }
    }
}