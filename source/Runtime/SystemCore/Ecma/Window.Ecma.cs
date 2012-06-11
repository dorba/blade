//----------------------------------------------
// ECMA core object
//----------------------------------------------

namespace System.Browser
{
    /// <summary>
    /// This interface defines functions that are present in the global namespace of ECMAScript.
    /// </summary>
    public partial interface Window
    {
        /// <summary>
        /// Represents the numeric value of infinity.
        /// </summary>
        object Infinity { get; }

        /// <summary>
        /// Represents the numeric value of a non-numeric value
        /// </summary>
        object NaN { get; }

        /// <summary>
        /// Represents the undefined object.
        /// </summary>
        object undefined { get; }

        /// <summary>
        /// Replaces each UTF-8 escape sequence with the character that it represents.
        /// </summary>
        /// <param name="uri">The URI to decode.</param>
        /// <returns>A decoded string.</returns>
        string decodeURI(string uri);

        /// <summary>
        /// Replaces each UTF-8 escape sequence with the character representation.
        /// </summary>
        /// <param name="uriComponent">The URI component to decode.</param>
        /// <returns>A decoded string.</returns>
        string decodeURIComponent(string uriComponent);

        /// <summary>
        /// Replaces applicable characters of a URI with their UTF-8 encoded representation.
        /// </summary>
        /// <param name="uri">The URI to encode.</param>
        /// <returns>An encoded string.</returns>
        string encodeURI(string uri);

        /// <summary>
        /// Replaces applicable characters of a URI component with their UTF-8 encoded representation.
        /// </summary>
        /// <param name="uriComponent">The URI component.</param>
        /// <returns>An encoded string.</returns>
        string encodeURIcomponent(string uriComponent);

        /// <summary>
        /// Executes a script at runtime.
        /// </summary>
        /// <param name="value">The script text.</param>
        void eval(string value);

        /// <summary>
        /// Gets a value indicating whether or not the input is a finite number.
        /// </summary>
        /// <param name="value">The input value.</param>
        /// <returns>True is the number is finite, false otherwise.</returns>
        bool isFinite(INumber value);

        /// <summary>
        /// Gets a value indicating whether or not the input is NaN.
        /// </summary>
        /// <param name="value">The input value.</param>
        /// <returns>True is the number is NaN, false otherwise.</returns>
        bool isNaN(INumber value);

        /// <summary>
        /// Converts a string to a floating point numeric value.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns>A floating point number.</returns>
        double parseFloat(string value);

        /// <summary>
        /// Converts a string to an integer value.
        /// </summary>
        /// <param name="value">The input string.</param>
        /// <returns>An integer.</returns>
        int parseInt(string value);
    }
}