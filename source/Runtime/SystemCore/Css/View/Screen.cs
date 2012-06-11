//----------------------------------------------
// Created from Auguest 2011 CSSOM View specification
// See: http://www.w3.org/TR/2011/WD-cssom-view-20110804/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// The definition for the browser screen object.
    /// </summary>
    public interface Screen
    {
        /// <summary>
        /// Gets the client screen height, in pixels.
        /// </summary>
        [ScriptField]
        int height { get; }

        /// <summary>
        /// Gets the client screen width, in pixels.
        /// </summary>
        [ScriptField]
        int width { get; }

        /// <summary>
        /// Gets the client pixel depth. 
        /// </summary>
        [ScriptField]
        int pixelDepth { get; }

        /// <summary>
        /// Gets the client color depth.
        /// </summary>
        [ScriptField]
        int colorDepth { get; }

        /// <summary>
        /// Gets the the client available width, in pixels.
        /// </summary>
        [ScriptField]
        int availWidth { get; }

        /// <summary>
        /// Gets the client available height, in pixels.
        /// </summary>
        [ScriptField]
        int availHeight { get; }
    }
}