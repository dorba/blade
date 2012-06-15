//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------

using System.Css;

namespace System.Dom
{
    /// <summary>
    /// Represents an element node.
    /// </summary>
    public abstract partial class Element
    {
        /// <summary>
        /// Gets or sets the top scroll offset.
        /// </summary>
        public int scrollTop { get; set; }

        /// <summary>
        /// Gets or sets the left scroll offset.
        /// </summary>
        public int scrollLeft { get; set; }

        /// <summary>
        /// Gets the scroll width.
        /// </summary>
        public int scrollWidth { get; private set; }

        /// <summary>
        /// Gets the scroll height.
        /// </summary>
        public int scrollHeight { get; private set; }

        /// <summary>
        /// Gets the width of the top border.
        /// </summary>
        public int clientTop { get; private set; }

        /// <summary>
        /// Gets the width of the left border.
        /// </summary>
        public int clientLeft { get; private set; }

        /// <summary>
        /// Gets the inner width.
        /// </summary>
        public int clientWidth { get; private set; }

        /// <summary>
        /// Gets the inner height.
        /// </summary>
        public int clientHeight { get; private set; }

        /// <summary>
        /// Gets all bounding rectangles.
        /// </summary>
        /// <returns>A collection of rectangles.</returns>
        public ClientRect[] getClientRects() { return null; }

        /// <summary>
        /// Gets the union of all bounding rectangles.
        /// </summary>
        /// <returns>A single rectangle.</returns>
        public ClientRect getBoundingClientRect() { return null; }

        /// <summary>
        /// Scrolls the element into view on the page.
        /// </summary>
        /// <param name="top">True to align top, false to align bottom.</param>
        public void scrollIntoView(bool top = true) { }
    }
}