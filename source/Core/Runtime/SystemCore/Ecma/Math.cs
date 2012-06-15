//----------------------------------------------
// ECMA core object
//----------------------------------------------

namespace System
{
    /// <summary>
    /// Represents the ECMA Math object.
    /// </summary>
    public sealed class Math
    {
        /// <summary>
        /// Euler's number (approx. 2.718)
        /// </summary>
        public const double E = 0;

        /// <summary>
        /// The natural logarithm of 2 (approx. 0.693)
        /// </summary>
		public const double LN2 = 0;

        /// <summary>
        /// The natural logarithm of 10 (approx. 2.302)
        /// </summary>
		public const double LN10 = 0;

        /// <summary>
        /// The base-2 logarithm of E (approx. 1.442)
        /// </summary>
		public const double LOG2E = 0;

        /// <summary>
        /// The base-10 logarithm of E (approx. 0.434)
        /// </summary>
		public const double LOG10E = 0;

        /// <summary>
        /// PI (approx. 3.14159)
        /// </summary>
		public const double PI = 0;

        /// <summary>
        /// The square root of 1/2 (approx. 0.707)
        /// </summary>
		public const double SQRT1_2 = 0;

        /// <summary>
        /// The square root of 2 (approx. 1.414)
        /// </summary>
		public const double SQRT2 = 0;

        /// <summary>
        /// Gets the absolute value of a number.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double abs(INumber x) { return 0; }

        /// <summary>
        /// Gets the arccosine of a number, in radians.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double acos(INumber x) { return 0; }

        /// <summary>
        /// Gets the arcsine of a number, in radians.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double asin(INumber x) { return 0; }

        /// <summary>
        /// Gets the arctangent of a number, in radians.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double atan(INumber x) { return 0; }

        /// <summary>
        /// Gets the arctangent of a number, in radians.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double atan2(INumber y, INumber x) { return 0; }

        /// <summary>
        /// Converts a number to an integer by rounding up.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>An integer.</returns>
		public static int ceil(INumber x) { return 0; }	

        /// <summary>
        /// Gets the cosine of a number, in radians.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
        public static double cos(INumber x) { return 0; }
                                                            
        /// <summary>
        /// Gets the exponential of a number.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double exp(INumber x) { return 0; }

        /// <summary>
        /// Converts a number to an integer by rounding down.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>An integer.</returns>
		public static int floor(INumber x) { return 0; }

        /// <summary>
        /// Gets the natural logarithm of a number.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double log(INumber x) { return 0; }

        /// <summary>
        /// Gets the highest value from a set of numbers.
        /// </summary>
        /// <param name="values">The input values.</param>
        /// <returns>A number.</returns>
		public static double max(params INumber[] values) { return 0; }

        /// <summary>
        /// Gets the lowest value from a set of numbers.
        /// </summary>
        /// <param name="values">The input values.</param>
        /// <returns>A number.</returns>
		public static double min(params INumber[] values) { return 0; }

        /// <summary>
        /// Gets the value of a number raised to a power.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <param name="y">The power to raise to.</param>
        /// <returns>A number.</returns>
		public static double pow(INumber x, INumber y) { return 0; }

        /// <summary>
        /// Gets a random number between 0 and 1.
        /// </summary>
        /// <returns>A number.</returns>
		public static double random() { return 0; }

        /// <summary>
        /// Converts to an integer, by rounding to the nearest whole number.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>An integer.</returns>
		public static int round(INumber x) { return 0; }

        /// <summary>
        /// Gets the sine of a number, in radians.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double sin(INumber x) { return 0; }

        /// <summary>
        /// Gets the square root of a number.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double sqrt(INumber x) { return 0; }

        /// <summary>
        /// Gets the tangent of a number, in radians.
        /// </summary>
        /// <param name="x">The input value.</param>
        /// <returns>A number.</returns>
		public static double tan(INumber x) { return 0; }
    }
}