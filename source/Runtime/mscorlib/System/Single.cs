
namespace System
{
	/// <summary>
	/// System float implementatin, exposed as ECMA Number.
	/// </summary>
	public struct Single : INumber
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


