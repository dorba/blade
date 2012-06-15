//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents an element node.
    /// </summary>
    public abstract partial class Element : Node
    {
        internal Element() { }

        /// <summary>
        /// Gets the tag name of the element.
        /// </summary>
        [ScriptField]
        public string tagName { get; private set; }

        /// <summary>
        /// Gets the namespace URI of this node.
        /// </summary>
        [ScriptField]
        public string namespaceURI { get; private set; }

        /// <summary>
        /// Gets the namespace prefix of the node.
        /// </summary>
        [ScriptField]
        public string prefix { get; private set; }

        /// <summary>
        /// Gets the local part of the qualified name of an element.
        /// </summary>
        [ScriptField]
        public string localName { get; private set; }

        /// <summary>
        /// Gets or sets the id attribute value.
        /// </summary>
        [ScriptField]
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the class attribute value.
        /// </summary>
        [ScriptField]
        public string className { get; set; }

        /// <summary>
        /// Gets that class attribute as a token list.
        /// </summary>
        [ScriptField]
        public DOMTokenList classList { get; private set; }

        /// <summary>
        /// Gets all attributes associated with the element.
        /// </summary>
        [ScriptField]
        public Attr[] attributes { get; private set; }

        /// <summary>
        /// Gets all child nodes of an element as a collection.
        /// </summary>
        [ScriptField]
        public HTMLCollection children { get; private set; }

        /// <summary>
        /// Gets the first direct child element of an element.
        /// </summary>
        [ScriptField]
        public Element firstElementChild { get; private set; }

        /// <summary>
        /// Gets the last direct child element of an element.
        /// </summary>
        [ScriptField]
        public Element lastElementChild { get; private set; }

        /// <summary>
        /// Gets the immediately preceding element.
        /// </summary>
        [ScriptField]
        public Element previousElementSibling { get; private set; }

        /// <summary>
        /// Gets the immediately following element.
        /// </summary>
        [ScriptField]
        public Element nextElementSibling { get; private set; }

        /// <summary>
        /// Gets the number of child nodes that are elements.
        /// </summary>
        [ScriptField]
        public int childElementCount { get; private set; }

        /// <summary>
        /// Gets an attribute value by attribute name.
        /// </summary>
        /// <param name="name">The attribute name.</param>
        /// <returns>The attribute value.</returns>
        public string getAttribute(string name) { return null; }

        /// <summary>
        /// Gets an attribute value by namspace and name.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="localName">The attribute name.</param>
        /// <returns>The attribute value.</returns>
        public string getAttributeNS(string namespaceURI, string localName) { return null; }

        /// <summary>
        /// Sets an attribute value by attribute name.
        /// </summary>
        /// <param name="name">The attribute name.</param>
        /// <param name="value">The new value.</param>
        public void setAttribute(string name, string value) { }

        /// <summary>
        /// Sets an attribute value by namespace and name.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="qualifiedName">The attribute name.</param>
        /// <param name="value">The new value.</param>
        public void setAttributeNS(string namespaceURI, string qualifiedName, string value) { }

        /// <summary>
        /// Removes an attribute by name.
        /// </summary>
        /// <param name="name">The attribute name.</param>
        public void removeAttribute(string name) { }

        /// <summary>
        /// Removes an attribute by namespace and name.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="localName">The attribute name.</param>
        public void removeAttributeNS(string namespaceURI, string localName) { }

        /// <summary>
        /// Gets a value indicating whether or not the element has a specific attribute.
        /// </summary>
        /// <param name="name">The attribute name.</param>
        /// <returns>True if the attribute exists, false otherwise.</returns>
        public bool hasAttribute(string name) { return false; }

        /// <summary>
        /// Gets a value indicating whether or not the element has a specific attribute.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="localName">The attribute name.</param>
        /// <returns>True if the attribute exists, false otherwise.</returns>
        public bool hasAttributeNS(string namespaceURI, string localName) { return false; }

        /// <summary>
        /// Gets all child elements with the specified tag name.
        /// </summary>
        /// <param name="name">The tag name.</param>
        /// <returns>A collection of matching elements.</returns>
        public HTMLCollection getElementsByTagName(string name) { return null; }

        /// <summary>
        /// Gets all child elements with the specified name and namespace.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="localName">The node name.</param>
        /// <returns>A collection of matching nodes.</returns>
        public HTMLCollection getElementsByTagNameNS(string namespaceURI, string localName) { return null; }

        /// <summary>
        /// Gets all child elements with the specified class name.
        /// </summary>
        /// <param name="className">The class name.</param>
        /// <returns>A collection of matching nodes.</returns>
        public HTMLCollection getElementsByClassName(string className) { return null; }
    }
}