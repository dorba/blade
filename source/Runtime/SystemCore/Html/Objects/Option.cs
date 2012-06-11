//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    /// <summary>
    /// Represents an HTML option element.
    /// </summary>
    public sealed class Option : HTMLOptionElement
    {
        /// <summary>
        /// Creates a new option element.
        /// </summary>
        public Option() { }

        /// <summary>
        /// Creates a new option element.
        /// </summary>
        /// <param name="text">The option text.</param>
        public Option(string text) { }

        /// <summary>
        /// Creates a new option element.
        /// </summary>
        /// <param name="text">The option text.</param>
        /// <param name="value">The option value.</param>
        public Option(string text, string value) { }

        /// <summary>
        /// Creates a new option element.
        /// </summary>
        /// <param name="text">The option text.</param>
        /// <param name="value">The option value.</param>
        /// <param name="isDefault">True if the option is the default selection.</param>
        public Option(string text, string value, bool isDefault) { }

        /// <summary>
        /// Creates a new option element.
        /// </summary>
        /// <param name="text">The option text.</param>
        /// <param name="value">The option value.</param>
        /// <param name="isDefault">True if the option is the default selection.</param>
        /// <param name="isSelected">True if the option should be initially selected.</param>
        public Option(string text, string value, bool isDefault, bool isSelected) { }
    }
}