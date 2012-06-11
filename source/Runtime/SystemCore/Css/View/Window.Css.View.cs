//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------
using System.Dom;
using System.Css;

namespace System.Browser
{
    /// <summary>
    /// The definition for the browser window object.
    /// </summary>
    public partial interface Window
    {
        /// <summary>
        /// Gets the Screen for the window.
        /// </summary>
        [ScriptField]
        Screen screen { get; }

        /// <summary>
        /// Gets the width of the content area of the browser window including, if rendered, the vertical scrollbar.
        /// </summary>
        [ScriptField]
        int innerWidth { get; }

        /// <summary>
        /// Gets the height of the content area of the browser window including, if rendered, the horizontal scrollbar.
        /// </summary>
        [ScriptField]
        int innerHeight { get; }

        /// <summary>
        /// Gets the number of pixels that the document has already been scrolled horizontally.
        /// </summary>
        [ScriptField]
        int scrollX { get; }

        /// <summary>
        /// An alias for <see cref="scrollX"/>.
        /// </summary>
        [ScriptField]
        int pageXOffset { get; }

        /// <summary>
        /// Gets the number of pixels that the document has already been scrolled vertically.
        /// </summary>
        [ScriptField]
        int scrollY { get; }

        /// <summary>
        /// An alias for <see cref="scrollY"/>.
        /// </summary>
        [ScriptField]
        int pageYOffset { get; }

        /// <summary>
        /// Gets the horizontal distance of the left border of the user's browser from the left side of the screen.
        /// </summary>
        [ScriptField]
        int screenX { get; }

        /// <summary>
        /// Gets the vertical distance of the top border of the user's browser from the top side of the screen.
        /// </summary>
        [ScriptField]
        int screenY { get; }

        /// <summary>
        /// Gets the width of the outside of the browser window.
        /// </summary>
        [ScriptField]
        int outerWidth { get; }

        /// <summary>
        /// Gets the height of the outside of the browser window.
        /// </summary>
        [ScriptField]
        int outerHeight { get; }

        /// <summary>
        /// Gets a <see cref="MediaQueryList"/> object representing the specified media query string.
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns>The requested media queries.</returns>
        MediaQueryList matchMedia(string queryString);

        /// <summary>
        /// Scrolls to a specific place in the document.
        /// </summary>
        /// <param name="x">The X position, in pixels.</param>
        /// <param name="y">The Y position, in pixels.</param>
        void scroll(int x, int y);

        /// <summary>
        /// Scrolls to a specific place in the document.
        /// </summary>
        /// <param name="x">The X position, in pixels.</param>
        /// <param name="y">The Y position, in pixels.</param>
        void scrollTo(int x, int y);

        /// <summary>
        /// Scrolls the document relative to its current position.
        /// </summary>
        /// <param name="deltaX">The X position change, in pixels.</param>
        /// <param name="deltaY">The Y position change, in pixels.</param>
        void scrollBy(int deltaX, int deltaY);
    }
}