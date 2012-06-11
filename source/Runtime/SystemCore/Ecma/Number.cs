//----------------------------------------------
// ECMA core object
//----------------------------------------------

namespace System
{
    /// <summary>
    /// The ECMA Number object.
    /// </summary>
	public sealed class Number : INumber
    {
        /// <summary>
        /// The maximum numeric value.
        /// </summary>
		public const double MAX_VALUE = 0;

        /// <summary>
        /// The minimum numeric value.
        /// </summary>
		public const double MIN_VALUE = 0;

        /// <summary>
        /// The value representing negative infinity.
        /// </summary>
		public const double NEGATIVE_INFINITY = 0;

        /// <summary>
        /// The value representing positive infinity.
        /// </summary>
		public const double POSITIVE_INFINITY = 0;

		/// <summary>
		/// Creates a new number, initialized to zero.
		/// </summary>
		public Number() { }

		/// <summary>
		/// Creates a new number.
		/// </summary>
		/// <param name="number">The numeric value.</param>
		public Number(INumber number) { }

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