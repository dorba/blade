//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Represents a single node in the document tree.
	/// </summary>
    public abstract class Node
    {
        internal Node() { }

        /// <summary>
        /// Represents a node of type <see cref="Element"/>
        /// </summary>
        public const int ELEMENT_NODE = 1;

        /// <summary>
        /// Represents a node of type <see cref="Attr"/>
        /// </summary>
        public const int ATTRIBUTE_NODE = 2;

        /// <summary>
        /// Represents a node of type <see cref="Text"/>
        /// </summary>
        public const int TEXT_NODE = 3;

        /// <summary>
        /// Represents a node of type CDATASection.
        /// </summary>
        public const int CDATA_SECTION_NODE = 4;

        /// <summary>
        /// Represents a node of type EntityReference.
        /// </summary>
        public const int ENTITY_REFERENCE_NODE = 5;

        /// <summary>
        /// Represents a node of type Entity.
        /// </summary>
        public const int ENTITY_NODE = 6;

        /// <summary>
        /// Represents a node of type <see cref="ProcessingInstruction"/>
        /// </summary>
        public const int PROCESSING_INSTRUCTION_NODE = 7;

        /// <summary>
        /// Represents a node of type <see cref="Comment"/>
        /// </summary>
        public const int COMMENT_NODE = 8;

        /// <summary>
        /// Represents a node of type <see cref="Document"/>
        /// </summary>
        public const int DOCUMENT_NODE = 9;

        /// <summary>
        /// Represents a node of type <see cref="DocumentType"/>
        /// </summary>
        public const int DOCUMENT_TYPE_NODE = 10;

        /// <summary>
        /// Represents a node of type <see cref="DocumentFragment"/>
        /// </summary>
        public const int DOCUMENT_FRAGMENT_NODE = 11;

        /// <summary>
        /// Represents a node of type Notation.
        /// </summary>
        public const int NOTATION_NODE = 12;

        /// <summary>
        /// Gets the type of the underlying object.
        /// </summary>
        [ScriptField]
        public int nodeType { get; private set; }

        /// <summary>
        /// Gets the name of this node, depending on its type.
        /// </summary>
        [ScriptField]
        public string nodeName { get; private set; }

        /// <summary>
        /// Gets the document associated with this node.
        /// </summary>
        [ScriptField]
        public Document ownerDocument { get; private set; }

        /// <summary>
        /// Gets the parent of this node.
        /// </summary>
        [ScriptField]
        public Node parentNode { get; private set; }

        /// <summary>
        /// Gets the first available parent element of this node.
        /// </summary>
        [ScriptField]
        public Element parentElement { get; private set; }

        /// <summary>
        /// Gets the children of this node.
        /// </summary>
        [ScriptField]
        public NodeList childNodes { get; private set; }

        /// <summary>
        /// Gets the first child of this node.
        /// </summary>
        [ScriptField]
        public Node firstChild { get; private set; }

        /// <summary>
        /// Gets the last child of this node.
        /// </summary>
        [ScriptField]
        public Node lastChild { get; private set; }

        /// <summary>
        /// Gets the previous sibling of this node.
        /// </summary>
        [ScriptField]
        public Node previousSibling { get; private set; }

        /// <summary>
        /// Gets the next sibling of this node.
        /// </summary>
        [ScriptField]
        public Node nextSibling { get; private set; }

        /// <summary>
        /// Gets or sets the value of this node.
        /// </summary>
        [ScriptField]
        public string nodeValue { get; set; }

        /// <summary>
        /// Gets or sets the text content of this node.
        /// </summary>
        [ScriptField]
        public string textContent { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the node has any children.
        /// </summary>
        /// <returns>True if the node has children, false otherwise.</returns>
        public bool hasChildNodes() { return false; }

        /// <summary>
        /// Gets a value indicating whether or not a specific node is contained within this node.
        /// </summary>
        /// <param name="other">The node to search for.</param>
        /// <returns>True if the node is contained within this node, false otherwise.</returns>
        public bool contains(Node other) { return false; }

        /// <summary>
        /// Inserts a new node in the child collection, before the specific reference node.
        /// </summary>
        /// <param name="newChild">The node to insert.</param>
        /// <param name="refChild">The reference node.</param>
        /// <returns>The inserted node.</returns>
        public Node insertBefore(Node newChild, Node refChild) { return null; }

        /// <summary>
        /// Replaces a node in the child collection.
        /// </summary>
        /// <param name="newChild">The node to insert.</param>
        /// <param name="oldChild">The node to replace.</param>
        /// <returns>The replaced node.</returns>
        public Node replaceChild(Node newChild, Node oldChild) { return null; }

        /// <summary>
        /// Removes a node in the child collection.
        /// </summary>
        /// <param name="oldChild">The node to remove.</param>
        /// <returns>The removed node.</returns>
        public Node removeChild(Node oldChild) { return null; }

        /// <summary>
        /// Adds a new node to the end of the child node collection.
        /// </summary>
        /// <param name="newChild">The node to add.</param>
        /// <returns>The added node.</returns>
        public Node appendChild(Node newChild) { return null; }

        /// <summary>
        /// Puts all text nodes in the full depth of the tree underneath this node.
        /// </summary>
        public void normalize() { }

        /// <summary>
        /// Creates a duplicate of this node.
        /// </summary>
        /// <param name="deep">True to recursively clone child nodes.</param>
        /// <returns>The new node.</returns>
        public Node cloneNode(bool deep = true) { return null; }

        /// <summary>
        /// Compares with another node for equality.
        /// </summary>
        /// <param name="node">The node to compare to.</param>
        /// <returns>True if the nodes are equal, false otherwise.</returns>
        public bool isEqualNode(Node node) { return false; }
    }
}
