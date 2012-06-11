//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
	/// <summary>
	/// Represents a CSS import rule.
	/// </summary>
    public sealed class CSSImportRule : CSSRule
    {
		internal CSSImportRule() { }

		/// <summary>
		/// Gets the URL specified by the import rule.
		/// </summary>
		[ScriptField]
		public string href { get; private set; }

		/// <summary>
		/// Gets the value of the media attribute applied to the stylesheet.
		/// </summary>
        [ScriptField]
		public MediaList media { get; private set; }

		/// <summary>
		/// Gets the associated stylesheet.
		/// </summary>
        [ScriptField]
		public CSSStyleSheet styleSheet { get; private set; }
    }
}