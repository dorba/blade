//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Service contract for any object that will act as a listener for media query changes.
    /// </summary>
    public interface MediaQueryListListener
    {
        /// <summary>
        /// Called when the media query list state changes.
        /// </summary>
        /// <param name="list">The changed media query list.</param>
        void handleChange(MediaQueryList list);
    }
}