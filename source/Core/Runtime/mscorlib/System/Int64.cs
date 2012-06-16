
using System.Reflection;

namespace System
{
    /// <summary>
    /// System long implementation, exposed as ECMAScript Number.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public struct Int64 : INumber
    {
        /// <summary>
        /// Converts the number to exponential form.
        /// </summary>
        /// <param name="value">The exponent power.</param>
        /// <returns>A text representation of the number.</returns>
        public string toExponential(INumber value) { return null; }

        /// <summary>
        /// Converts the number to a fixed form.
        /// </summary>
        /// <param name="value">The number of decimal places.</param>
        /// <returns>A text representation of the number.</returns>
        public string toFixed(INumber value) { return null; }

        /// <summary>
        /// Converts the number to a fixed precision form.
        /// </summary>
        /// <param name="value">The number of decimal places.</param>
        /// <returns>A text representation of the number.</returns>
        public string toPrecision(INumber value) { return null; }
    }
}


