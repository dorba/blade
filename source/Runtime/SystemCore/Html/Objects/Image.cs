//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    /// <summary>
    /// Represents an HMLT image element.
    /// </summary>
    public sealed class Image : HTMLImageElement
    {
        /// <summary>
        /// Creates a new image element.
        /// </summary>
        public Image() { }

        /// <summary>
        /// Creates a new image element, with a specific width.
        /// </summary>
        /// <param name="width">The width, in pixels.</param>
        public Image(int width) { }

        /// <summary>
        /// Creates a new image element, with a specific height and width.
        /// </summary>
        /// <param name="width">The width, in pixels.</param>
        /// <param name="height">The height, in pixels.</param>
        public Image(int width, int height) { }
    }
}