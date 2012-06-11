//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------
using System.Dom;
using System.Css;

namespace System.Browser
{
    /// <summary>
    /// The definition for the browser window object.
    /// </summary>
    public partial interface Window
    {
        /// <summary>
        /// Gets the final CSS values resulting from all CSS properties applied to an element.
        /// </summary>
        /// <param name="elt">The target element.</param>
        /// <returns>A CSS style.</returns>
        CSSStyleDeclaration getComputedStyle(Element elt);

        /// <summary>
        /// Gets the final CSS values resulting from all CSS properties applied to an element.
        /// </summary>
        /// <param name="elt">The target element.</param>
        /// <param name="pseudoElt">The pseudo-element to match.</param>
        /// <returns>A CSS style.</returns>
        CSSStyleDeclaration getComputedStyle(Element elt, string pseudoElt);
    }
}