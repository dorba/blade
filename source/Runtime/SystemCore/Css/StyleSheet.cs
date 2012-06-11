//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------
using System.Dom;

namespace System.Css
{
	/// <summary>
	/// Represents an abstract stylesheet.
	/// </summary>
    public abstract class StyleSheet
    {
        internal StyleSheet() { }

        /// <summary>
        /// Get the type name.
        /// </summary>
		[ScriptField]
		public string type { get; private set; }

        /// <summary>
        /// Gets the node which contains the style sheet.
        /// </summary>
        [ScriptField]
		public Node ownerNode { get; private set; }

        /// <summary>
        /// Gets the parent of this style sheet.
        /// </summary>
        [ScriptField]
		public StyleSheet parentStyleSheet { get; private set; }

        /// <summary>
        /// Gets the location of the style sheet.
        /// </summary>
        [ScriptField]
		public string href { get; private set; }

        /// <summary>
        /// Gets the title text.
        /// </summary>
        [ScriptField]
		public string title { get; private set; }

        /// <summary>
        /// Gets the supported media of the style sheet.
        /// </summary>
        [ScriptField]
		public MediaList media { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating if the style sheet is disabled.
        /// </summary>
        [ScriptField]
        public bool disabled { get; set; }
    }
}