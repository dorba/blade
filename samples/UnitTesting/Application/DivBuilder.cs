using System;
using System.Dom;
using System.Html;
using jQueryLib;

namespace Application
{
    /// <summary>
    /// A class to build some UI elements, using jQuery.
    /// </summary>
    public class DivBuilder
    {
        private jQuery _jqBody;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public DivBuilder()
        {
            _jqBody = jQuery.Select(window.document.body);
        }

        /// <summary>
        /// Appends a square div to the body
        /// </summary>
        /// <param name="color">The background color.</param>
        /// <param name="size">The height and width.</param>
        public void CreateBox(string color, int size)
        {
            var box = jQuery.Select("<div></div>");
            
            box.css("background-color", color);
            box.css("width", size + "px");
            box.css("height", size + "px");

            _jqBody.append(box);
        }
    }
}
