//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------
using System.Dom;

namespace System.Html
{
    /// <summary>
    /// Represents an HTML element node.
    /// </summary>
    public abstract partial class HTMLElement
    {
        /// <summary>
        /// Gets the closest positioned containing element.
        /// </summary>
        public Element offsetParent { get; private set; }

        /// <summary>
        /// Gets the number of pixels between the top of this element and the top of its offset parent.
        /// </summary>
        public int offsetTop { get; private set; }

        /// <summary>
        /// Gets the number of pixels between the left of this element and the left of its offset parent.
        /// </summary>
        public int offsetLeft { get; private set; }

        /// <summary>
        /// Gets the full layout width.
        /// </summary>
        public int offsetWidth { get; private set; }

        /// <summary>
        /// Gets the full layout height.
        /// </summary>
        public int offsetHeight { get; private set; }
    }
}