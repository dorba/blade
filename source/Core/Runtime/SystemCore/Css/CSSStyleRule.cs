//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Represents a single rule set in a CSS style sheet.
    /// </summary>
    public sealed class CSSStyleRule : CSSRule
    {
		internal CSSStyleRule() { }

        /// <summary>
        /// Gets the declaration-block of this rule set.
        /// </summary>
		[ScriptField]
		public CSSStyleDeclaration style { get; private set; }

        /// <summary>
        /// Gets or sets the textual representation of the selector for the rule set.
        /// </summary>
        [ScriptField]
        public string selectorText { get; set; }
    }
}