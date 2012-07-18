//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents a document node.
    /// </summary>
    public sealed partial class Document : Node
    {
        internal Document() { }

        /// <summary>
        /// Gets the document type node for this document.
        /// </summary>
        [ScriptField]
        public DocumentType doctype { get; private set; }

        /// <summary>
        /// Gets the DOM implementation for this document.
        /// </summary>
        [ScriptField]
        public DOMImplementation implementation { get; private set; }

        /// <summary>
        /// Gets the root element of the document.
        /// </summary>
        [ScriptField]
        public Element documentElement { get; private set; }

        /// <summary>
        /// Gets the document URL.
        /// </summary>
        [ScriptField]
        public string URL { get; private set; }

        /// <summary>
        /// Gets the document URL.
        /// </summary>
        [ScriptField]
        public string documentURI { get; private set; }

        /// <summary>
        /// Gets a value of either "CSS1Compat" or "BackCompat", depending on
        /// whether or not the document is in quirks mode.
        /// </summary>
        [ScriptField]
        public string compatMode { get; private set; }

        /// <summary>
        /// Gets the document text encoding.
        /// </summary>
        [ScriptField]
        public string characterSet { get; private set; }

        /// <summary>
        /// Gets the document context type.
        /// </summary>
        [ScriptField]
        public string contentType { get; private set; }

        /// <summary>
        /// Creates a new element.
        /// </summary>
        /// <param name="tagName">The element tag name.</param>
        /// <returns>The newly created element.</returns>
        public Element createElement(string tagName) { return null; }

        /// <summary>
        /// Creates a new element, with a specific namespace.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="qualifiedName">The qualified node name.</param>
        /// <returns>The newly created element.</returns>
        public Element createElementNS(string namespaceURI, string qualifiedName) { return null; }

        /// <summary>
        /// Creates an empty document fragment.
        /// </summary>
        /// <returns>The newly created fragment.</returns>
        public DocumentFragment createDocumentFragment() { return null; }

        /// <summary>
        /// Creates a text node.
        /// </summary>
        /// <param name="data">The inner text.</param>
        /// <returns>The newly created text node.</returns>
        public Text createTextNode(string data) { return null; }

        /// <summary>
        /// Creates a comment node.
        /// </summary>
        /// <param name="data">The inner text.</param>
        /// <returns>The newly created comment node.</returns>
        public Comment createComment(string data) { return null; }

        /// <summary>
        /// Creates a processing instruction node.
        /// </summary>
        /// <param name="target">The target value.</param>
        /// <param name="data">The data value.</param>
        /// <returns>The newly created processing instruction node.</returns>
        public ProcessingInstruction createProcessingInstruction(string target, string data) { return null; }

        /// <summary>
        /// Creates a new event object.
        /// </summary>
        /// <param name="eventName">The event interface name.</param>
        /// <returns>An event object.</returns>
        public Event createEvent(string eventName) { return null; }

        /// <summary>
        /// Creates a new range object.
        /// </summary>
        /// <returns>A range object.</returns>
        public Range createRange() { return null; }

        /// <summary>
        /// Creates a <see cref="NodeIterator"/> object.
        /// </summary>
        /// <param name="root">The node at which to begin traversal.</param>
        /// <param name="whatToShow">A NodeFilter constant indicating which nodes to iterate over.</param>
        /// <param name="filter">An object inheriting the <see cref="NodeFilter"/> class.</param>
        /// <returns>A node iterator object.</returns>
        public NodeIterator createNodeIterator(Node root, int whatToShow = NodeFilter.SHOW_ALL, NodeFilter filter = null) { return null; }

        /// <summary>
        /// Creates a <see cref="TreeWalker"/> object.
        /// </summary>
        /// <param name="root">The node at which to begin traversal.</param>
        /// <param name="whatToShow">A NodeFilter constant indicating which nodes to iterate over.</param>
        /// <param name="filter">An object inheriting the <see cref="NodeFilter"/> class.</param>
        /// <returns>A tree walker object.</returns>
        public TreeWalker createTreeWalker(Node root, int whatToShow = NodeFilter.SHOW_ALL, NodeFilter filter = null) { return null; }

        /// <summary>
        /// Gets all elements in the document with the specified tag name.
        /// </summary>
        /// <param name="tagname">The tag name.</param>
        /// <returns>A collection of matching elements.</returns>
        public HTMLCollection getElementsByTagName(string tagname) { return null; }

        /// <summary>
        /// Gets all elements in the document with the specified namespace and name.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="localName">The node name.</param>
        /// <returns>A collection of matching elements.</returns>
        public HTMLCollection getElementsByTagNameNS(string namespaceURI, string localName) { return null; }

        /// <summary>
        /// Gets all elements in the document with the specified class name.
        /// </summary>
        /// <param name="className">The class name.</param>
        /// <returns>A collection of matching elements.</returns>
        public HTMLCollection getElementsByClassName(string className) { return null; }

        /// <summary>
        /// Gets a single element in the document by ID.
        /// </summary>
        /// <param name="elementId">The element ID.</param>
        /// <returns>The matching element.</returns>
        public Element getElementById(string elementId) { return null; }

        /// <summary>
        /// Creates a copy of a node from an external document.
        /// </summary>
        /// <param name="importedNode">The node from another document.</param>
        /// <param name="deep">True to recursively copy child nodes.</param>
        /// <returns>The newly created node.</returns>
        public Node importNode(Node importedNode, bool deep = true) { return null; }

        /// <summary>
        /// Adopts a node from an external document.
        /// </summary>
        /// <param name="node">The external node.</param>
        /// <returns>The adopted node.</returns>
        public Node adoptNode(Node node) { return null; }

        /// <summary>
        /// Gets a value indicating whether the object currently has focus.
        /// </summary>
        /// <returns></returns>
        public bool hasFocus() { return true; }
    }
}