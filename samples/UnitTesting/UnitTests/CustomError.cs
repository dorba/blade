using System;
using System.Dom;
using System.Html;
using Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    /// <summary>
    /// Provides an example of assertion with a custom error message.
    /// </summary>
    [TestClass]
    public class CustomError
    {
        /// <summary>
        /// Fails with a custom error, and displays the browser date string.
        /// </summary>
        [TestMethod]
        public void FailWithCustomError()
        {
            Assert.Fail("This is a custom error, written on: {0}",
                new[] { (new Date()).toDateString() });
        }
    }
}
