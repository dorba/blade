//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
    public abstract class CSSRule
    {
        internal CSSRule() { }

        /// <summary>
        /// The rule is a CSSUnknownRule.
        /// </summary>
        public const int UNKNOWN_RULE = 0;

        /// <summary>
        /// The rule is a CSSStyleRule.
        /// </summary>
        public const int STYLE_RULE = 1;

        /// <summary>
        /// The rule is a CSSCharsetRule.
        /// </summary>
        public const int CHARSET_RULE = 2;

        /// <summary>
        /// The rule is a CSSImportRule.
        /// </summary>
        public const int IMPORT_RULE = 3;

        /// <summary>
        /// The rule is a CSSMediaRule.
        /// </summary>
        public const int MEDIA_RULE = 4;

        /// <summary>
        /// The rule is a CSSFontFaceRule.
        /// </summary>
        public const int FONT_FACE_RULE = 5;

        /// <summary>
        /// The rule is a CSSPageRule.
        /// </summary>
        public const int PAGE_RULE = 6;

		/// <summary>
		/// The rule is a NamespaceRule.
		/// </summary>
		public const int NAMESPACE_RULE = 10;

        /// <summary>
        /// Gets the rule type.
        /// </summary>
        [ScriptField]
		public int type { get; private set; }

        /// <summary>
        /// Gets the style sheet containing this rule.
        /// </summary>
		[ScriptField]
		public CSSStyleSheet parentStyleSheet { get; private set; }

        /// <summary>
        /// Gets the parent rule.
        /// </summary>
        [ScriptField]
		public CSSRule parentRule { get; private set; }

        /// <summary>
        /// Gets or sets the text value.
        /// </summary>
        [ScriptField]
        public string cssText { get; set; }
    }
}