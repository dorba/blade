using System;
using System.Dom;
using System.Html;

namespace Application
{
    /// <summary>
    /// A simple class to test addition and subtraction.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds two numbers together.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The result.</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts a number from another.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The result.</returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
