//----------------------------------------------
// Created from April 2012 DOM specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// An object which can be used to navigate through a tree.
    /// </summary>
    public sealed class TreeWalker
    {
        internal TreeWalker() { }

        /// <summary>
        /// Gets the root node.
        /// </summary>
        [ScriptField]
        public Node root { get; private set; }

        /// <summary>
        /// Gets a value indicating what type of nodes are visible to the tree walker.
        /// </summary>
        [ScriptField]
        public int whatToShow { get; private set; }

        /// <summary>
        /// Gets a filter used to sreen nodes.
        /// </summary>
        [ScriptField]
        public NodeFilter filter { get; private set; }

        /// <summary>
        /// Gets or sets the current node.
        /// </summary>
        [ScriptField]
        public Node currentNode { get; set; }

        /// <summary>
        /// Moves to and returns the parent of the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node parentNode() { return null; }

        /// <summary>
        /// Moves to and returns the first child of the current node.
        /// </summary>
        /// <returns>A node.</returns>
        public Node firstChild() { return null; }

        /// <summary>
        /// Moves to and returns the last child of the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node lastChild() { return null; }

        /// <summary>
        /// Moves to and returns the previous sibling of the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node previousSibling() { return null; }

        /// <summary>
        /// Moves to and returns the next sibling of the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node nextSibling() { return null; }

        /// <summary>
        /// Moves to and returns the previous node in document order, relative to the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node previousNode() { return null; }

        /// <summary>
        /// Moves to and returns the next node in document order, relative to the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node nextNode() { return null; }
    }
}