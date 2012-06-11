//----------------------------------------------
// Blade common JS/.NET interface
//----------------------------------------------
using System.Reflection;

namespace System
{
    /// <summary>
    /// ECMA number definition.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface INumber
    {
        /// <summary>
        /// Converts the number to exponential form.
        /// </summary>
        /// <param name="value">The exponent power.</param>
        /// <returns>A text representation of the number.</returns>
        string toExponential(INumber value);

        /// <summary>
        /// Converts the number to a fixed form.
        /// </summary>
        /// <param name="value">The number of decimal places.</param>
        /// <returns>A text representation of the number.</returns>
        string toFixed(INumber value);

        /// <summary>
        /// Converts the number to a fixed precision form.
        /// </summary>
        /// <param name="value">The number of decimal places.</param>
        /// <returns>A text representation of the number.</returns>
        string toPrecision(INumber value);
    }
}