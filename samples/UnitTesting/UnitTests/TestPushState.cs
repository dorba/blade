using System;
using System.Dom;
using System.Html;
using Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    /// <summary>
    /// Test the browser's history.pushState function.
    /// </summary>
    [TestClass]
    public class TestPushState
    {
        /// <summary>
        /// Calls the pushState function. This will fail in browsers
        /// that do not support pushState. For example, in IE9.
        /// </summary>
        [TestMethod]
        public void TryPushState()
        {
            history.pushState(null, "newTitle", "newUrl");
        }
    }
}
