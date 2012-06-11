//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
	/// <summary>
	/// Represents a CSS media rule.
	/// </summary>
    public sealed class CSSMediaRule : CSSRule
    {
		internal CSSMediaRule() { }

		/// <summary>
		/// Gets the media queries defined by the media rule.
		/// </summary>
		[ScriptField]
		public MediaList media { get; private set; }

		/// <summary>
		/// Gets the rules specified with the media rule.
		/// </summary>
        [ScriptField]
		public CSSRule[] cssRules { get; private set; }

		/// <summary>
		/// Adds a new rule.
		/// </summary>
		/// <param name="rule">The rule to add.</param>
		/// <param name="index">The index to add at.</param>
		/// <returns></returns>
        public int insertRule(string rule, int index) { return 0; }

		/// <summary>
		/// Removes a rule.
		/// </summary>
		/// <param name="index">The index to remove at.</param>
        public void deleteRule(int index) { }
    }
}