//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Represents a CSS style sheet.
    /// </summary>
    public sealed class CSSStyleSheet : StyleSheet
    {
		internal CSSStyleSheet() { }

        /// <summary>
        /// Gets the owner if the style sheet was imported by a rule.
        /// </summary>
		[ScriptField]
		public CSSRule ownerRule { get; private set; }
        

        /// <summary>
        /// Gets the CSS rule collection.
        /// </summary>
        [ScriptField]
		public CSSRule[] cssRules { get; private set; }

        /// <summary>
        /// Inserts a new rule into the style sheet.
        /// </summary>
        /// <param name="rule">The rule name.</param>
        /// <param name="index">The index to insert at.</param>
        /// <returns>The inserted index.</returns>
        public int insertRule(string rule, int index) { return 0; }

        /// <summary>
        /// Deletes a rule from the style sheet.
        /// </summary>
        /// <param name="index">The index to delete at.</param>
        public void deleteRule(int index) { }
    }
}