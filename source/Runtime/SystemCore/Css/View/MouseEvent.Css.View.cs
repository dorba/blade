//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents an event that is created by a mouse action.
    /// </summary>
    public sealed partial class MouseEvent
    {
        /// <summary>
        /// Gets the x-coordinate where the event occurred, relative to the origin of the initial containing block.
        /// </summary>
        public int pageX { get; private set; }

        /// <summary>
        /// Gets the y-coordinate where the event occurred, relative to the origin of the initial containing block.
        /// </summary>
        public int pageY { get; private set; }

        /// <summary>
        /// Alias for <see cref="clientX"/>.
        /// </summary>
        public int x { get; private set; }

        /// <summary>
        /// Alias for <see cref="clientY"/>.
        /// </summary>
        public int y { get; private set; }

        /// <summary>
        /// Gets the x-coordinate where the event occurred, relative to the origin of the padding edge.
        /// </summary>
        public int offsetX { get; private set; }

        /// <summary>
        /// Gets the y-coordinate where the event occurred, relative to the origin of the padding edge.
        /// </summary>
        public int offsetY { get; private set; }

        // -------------------------------------------
        // Note: these are part of extended interface
        // However they already exist
        // -------------------------------------------
        //public int clientX { get; private set; }
        //public int clientY { get; private set; }
        //public int screenX { get; private set; }
        //public int screenY { get; private set; }
    }
}