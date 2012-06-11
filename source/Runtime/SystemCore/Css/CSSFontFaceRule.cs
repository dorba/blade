//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
	/// <summary>
	/// Represents a CSS font face rule.
	/// </summary>
    public sealed class CSSFontFaceRule : CSSRule
    {
		internal CSSFontFaceRule() { }

		/// <summary>
		/// Gets the CSS style declaration for the rule.
		/// </summary>
		[ScriptField]
		public CSSStyleDeclaration style { get; private set; }
    }
}