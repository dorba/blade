using System;
using System.Dom;
using System.Html;
using Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    /// <summary>
    /// Test the calculator object
    /// </summary>
    [TestClass]
    public class TestCalculator
    {
        /// <summary>
        /// Tests the calculator's add method.
        /// </summary>
        [TestMethod]
        public void OnePlusOneIsTwo()
        {
            var calc = new Calculator();
            var two = calc.Add(1, 1);

            Assert.AreEqual(2, two);
        }

        /// <summary>
        /// Tests the calculator's subtract method.
        /// </summary>
        [TestMethod]
        public void TenMinusFiveIsFive()
        {
            var calc = new Calculator();
            var five = calc.Subtract(10, 5);

            Assert.AreEqual(5, five);
        }
    }
}
