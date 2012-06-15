//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
	/// <summary>
	/// Represents a CSS page rule.
	/// </summary>
    public sealed class CSSPageRule : CSSRule
    {
		internal CSSPageRule() { }

		/// <summary>
		/// Gets the CSS style declaration for the rule.
		/// </summary>
		[ScriptField]
		public CSSStyleDeclaration style { get; private set; }

		/// <summary>
		/// Gets or sets the selector text.
		/// </summary>
        [ScriptField]
        public string selectorText { get; set; }
    }
}