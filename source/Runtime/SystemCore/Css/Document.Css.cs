//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------
using System.Css;

namespace System.Dom
{
    /// <summary>
    /// Represents a document node.
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// Gets the style sheets applied to the document.
        /// </summary>
        [ScriptField]
        public StyleSheet[] styleSheets { get; private set; }

        /// <summary>
        /// Gets or sets the name of the currently selected style sheet.
        /// </summary>
        [ScriptField]
        public string selectedStyleSheetSet { get; set; }

        /// <summary>
        /// Gets the name of the last style sheet.
        /// </summary>
        [ScriptField]
        public string lastStyleSheetSet { get; private set; }

        /// <summary>
        /// Gets the name of the preferred style sheet.
        /// </summary>
        [ScriptField]
        public string preferredStyleSheetSet { get; private set; }

        /// <summary>
        /// Gets the name of each style sheet.
        /// </summary>
        [ScriptField]
        public string[] styleSheetSets { get; private set; }

        /// <summary>
        /// Enables the style sheet with the specified name, and 
        /// disables all other named style sheets.
        /// </summary>
        /// <param name="name">The style sheet to enable.</param>
        public void enableStyleSheetsForSet(string name) { }
    }
}