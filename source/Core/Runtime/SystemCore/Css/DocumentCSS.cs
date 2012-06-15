//----------------------------------------------
// Created from DOM Level 2 specification
// See: http://www.w3.org/TR/2000/REC-DOM-Level-2-Style-20001113/css.html
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents a document with a CSS view.
    /// </summary>
    public sealed class DocumentCSS : DocumentStyle
    {
        /// <summary>
        /// Gets the override style declaration for a specified element.
        /// </summary>
        /// <param name="elt">The target element.</param>
        /// <param name="pseudoElt">The pseudo element.</param>
        /// <returns>The override style declaration.</returns>
        public CSSStyleDeclaration getOverrideStyle(Element elt, string pseudoElt) { return null; }
    }
}
