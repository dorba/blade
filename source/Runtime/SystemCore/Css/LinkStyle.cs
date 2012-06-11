//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Represents a link style within a style sheet.
    /// </summary>
    public sealed class LinkStyle
    {
        internal LinkStyle() { }

        /// <summary>
        /// Gets the containing style sheet.
        /// </summary>
        [ScriptField]
        public StyleSheet sheet { get; private set; }
    }
}