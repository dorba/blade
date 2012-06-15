//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Represents a rectangular object.
    /// </summary>
    public sealed class ClientRect
    {
        internal ClientRect() { }

        /// <summary>
        /// Gets the y-coordinate for the top side of the rectangle.
        /// </summary>
        [ScriptField]
        public int top { get; private set; }

        /// <summary>
        /// Gets the x-coordinate for the right side of the rectangle.
        /// </summary>
        [ScriptField]
        public int right { get; private set; }

        /// <summary>
        /// Gets the y-coordinate for the bottom side of the rectangle.
        /// </summary>
        [ScriptField]
        public int bottom { get; private set; }

        /// <summary>
        /// Gets the x-coordinate for the left side of the rectangle.
        /// </summary>
        [ScriptField]
        public int left { get; private set; }

        /// <summary>
        /// Gets the width of the rectangle.
        /// </summary>
        [ScriptField]
        public int width { get; private set; }

        /// <summary>
        /// Gets the height of the rectangle.
        /// </summary>
        [ScriptField]
        public int height { get; private set; }
    }
}