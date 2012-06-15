//----------------------------------------------
// Blade common JS/.NET interface
//----------------------------------------------
using System.Reflection;

namespace System
{
    /// <summary>
    /// ECMA regular expression definition.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IRegularExpression
    {
        /// <summary>
        /// Gets a value indicating whether or not the regular expression's global flag is set.
        /// </summary>
        [ScriptField]
        bool global { get; }

        /// <summary>
        /// Gets a value indicating whether or not the regular expression's ignore case flag is set.
        /// </summary>
        [ScriptField]
        bool ignoreCase { get; }

        /// <summary>
        /// Gets or sets the last index of the regular expression.
        /// </summary>
        [ScriptField]
        int lastIndex { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the regular expression's multiline flag is set.
        /// </summary>
        [ScriptField]
        bool multiline { get; }

        /// <summary>
        /// Get the regular expression source text.
        /// </summary>
        [ScriptField]
        string source { get; }

        /// <summary>
        /// Executes the regular expression.
        /// </summary>
        /// <param name="input">The input text.</param>
        /// <returns>A collection of matches.</returns>
        string[] exec(string input);

        /// <summary>
        /// Tests the regular expression for matches.
        /// </summary>
        /// <param name="input">The input text.</param>
        /// <returns>True if the input matches, false otherwise.</returns>
        bool test(string input);
    }
}