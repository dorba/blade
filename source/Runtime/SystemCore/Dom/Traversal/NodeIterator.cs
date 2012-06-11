//----------------------------------------------
// Created from April 2012 DOM specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// An object used to step through a set of nodes.
    /// </summary>
    public sealed class NodeIterator
    {
        internal NodeIterator() { }

        /// <summary>
        /// Gets the root node.
        /// </summary>
        [ScriptField]
        public Node root { get; private set; }

        /// <summary>
        /// Gets a value indicating what nodes are visible to the iterator.
        /// </summary>
        [ScriptField]
        public int whatToShow { get; private set; }

        /// <summary>
        /// Gets the node filter used during iteration.
        /// </summary>
        [ScriptField]
        public NodeFilter filter { get; private set; }

        /// <summary>
        /// Moves to and returns the next node in document order, relative to the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node nextNode() { return null; }

        /// <summary>
        /// Moves to and returns the previous node in document order, relative to the current node.
        /// </summary>
        /// <returns>The specified node.</returns>
        public Node previousNode() { return null; }

        /// <summary>
        /// Detaches the node iterator from the tree.
        /// </summary>
        public void detach() { }
    }
}