using System;
using System.Dom;
using System.Html;
using Application;
using jQueryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    /// <summary>
    /// Test the div builder object
    /// </summary>
    [TestClass]
    public class TestDivBuilder
    {
        private static readonly string[] Colors = new[] {
            "red", "green", "blue", "yellow"
        };

        /// <summary>
        /// Creates four colored boxes.
        /// </summary>
        [TestMethod]
        public void BuildColoredBoxes()
        {
            // clear the document body
            var jqBody = jQuery.Select(window.document.body);
            jqBody.empty();

            // build the boxes
            var builder = new DivBuilder();

            for (int i = 0; i < Colors.length; i++)
                builder.CreateBox(Colors[i], 100);

            // check that four children exist on the body
            Assert.AreEqual(4, jqBody.children().length);
        }
    }
}
