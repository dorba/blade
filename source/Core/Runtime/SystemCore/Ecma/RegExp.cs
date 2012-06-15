//----------------------------------------------
// ECMA core object
//----------------------------------------------

namespace System
{
    /// <summary>
    /// Represents the ECMA regular expression object.
    /// </summary>
    public sealed class RegExp : IRegularExpression
    {
        /// <summary>
        /// Creates a new regular expression.
        /// </summary>
        /// <param name="pattern">The regex pattern.</param>
        public RegExp(string pattern) { }

        /// <summary>
        /// Creates a new regular expression.
        /// </summary>
        /// <param name="pattern">The regex pattern.</param>
        /// <param name="flags">The regex flags.</param>
        public RegExp(string pattern, string flags) { }

        /// <summary>
        /// Gets a value indicating whether or not the regular expression's global flag is set.
        /// </summary>
        [ScriptField]
        public bool global { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the regular expression's ignore case flag is set.
        /// </summary>
        [ScriptField]
        public bool ignoreCase { get; private set; }

        /// <summary>
        /// Gets or sets the last index of the regular expression.
        /// </summary>
        [ScriptField]
        public int lastIndex { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the regular expression's multiline flag is set.
        /// </summary>
        [ScriptField]
        public bool multiline { get; private set; }

        /// <summary>
        /// Get the regular expression source text.
        /// </summary>
        [ScriptField]
        public string source { get; private set; }

        /// <summary>
        /// Executes the regular expression.
        /// </summary>
        /// <param name="input">The input text.</param>
        /// <returns>A collection of matches.</returns>
        public string[] exec(string input) { return null; }

        /// <summary>
        /// Tests the regular expression for matches.
        /// </summary>
        /// <param name="input">The input text.</param>
        /// <returns>True if the input matches, false otherwise.</returns>
        public bool test(string input) { return false; }
    }
}