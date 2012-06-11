//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Represents a collection of media queries on a document.
    /// </summary>
    public sealed class MediaQueryList
    {
        internal MediaQueryList() { }

        /// <summary>
        /// Gets the serialized media query list.
        /// </summary>
        public string media { get; private set; }

        /// <summary>
        /// Gets a value indicating if the document matches the media query list.
        /// </summary>
        public bool matches { get; private set; }

        /// <summary>
        /// Adds a new listener to the media query list.
        /// </summary>
        /// <param name="listener">The listener to add.</param>
        void addListener(MediaQueryListListener listener) { }

        /// <summary>
        /// Removes an existing listener from the media query list.
        /// </summary>
        /// <param name="listener">The listener to remove.</param>
        void removeListener(MediaQueryListListener listener) { }
    }
}