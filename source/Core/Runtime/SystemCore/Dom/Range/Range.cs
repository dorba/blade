//----------------------------------------------
// Created from April 2012 DOM specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents a fragment of a document.
    /// </summary>
    public sealed partial class Range
    {
        internal Range() { }

        /// <summary>
        /// Compares from start of source, to start of range.
        /// </summary>
        public const int START_TO_START = 0;

        /// <summary>
        /// Compares from start of source, to end of range.
        /// </summary>
        public const int START_TO_END = 1;

        /// <summary>
        /// Compares from end of source, to end of range.
        /// </summary>
        public const int END_TO_END = 2;

        /// <summary>
        /// Compares from end of source, to start of range.
        /// </summary>
        public const int END_TO_START = 3;

        /// <summary>
        /// Gets the Node within which the Range starts.
        /// </summary>
        [ScriptField]
        public Node startContainer { get; private set; }

        /// <summary>
        /// Gets a number representing where in the startContainer the Range starts.
        /// </summary>
        [ScriptField]
        public int startOffset { get; private set; }

        /// <summary>
        /// Gets the Node within which the Range ends.
        /// </summary>
        [ScriptField]
        public Node endContainer { get; private set; }

        /// <summary>
        /// Gets a number representing where in the endContainer the Range ends.
        /// </summary>
        [ScriptField]
        public int endOffset { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the range's start and end points are at the same position.
        /// </summary>
        [ScriptField]
        public bool collapsed { get; private set; }

        /// <summary>
        /// Gets the deepest Node that contains the startContainer and endContainer Nodes.
        /// </summary>
        [ScriptField]
        public Node commonAncestorContainer { get; private set; }

        /// <summary>
        /// Sets the start position of a range.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        /// <param name="offset">The reference offset.</param>
        public void setStart(Node refNode, int offset) { }

        /// <summary>
        /// Sets the end position of a range.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        /// <param name="offset">The reference offset.</param>
        public void setEnd(Node refNode, int offset) { }

        /// <summary>
        /// Sets the start position of a range to the node before another node.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        public void setStartBefore(Node refNode) { }

        /// <summary>
        /// Sets the start position of a range to the node after another node.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        public void setStartAfter(Node refNode) { }

        /// <summary>
        /// Sets the end position of a range to the node before another node.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        public void setEndBefore(Node refNode) { }

        /// <summary>
        /// Sets the end position of a range to the node after another node.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        public void setEndAfter(Node refNode) { }

        /// <summary>
        /// Collapses the Range to one of its boundary points.
        /// </summary>
        /// <param name="toStart">True to collapse to start, false to collapse to end.</param>
        public void collapse(bool toStart) { }

        /// <summary>
        /// Sets the range to contain the node and its contents.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        public void selectNode(Node refNode) { }

        /// <summary>
        /// Sets the range to contain the contents of a node.
        /// </summary>
        /// <param name="refNode">The reference node.</param>
        public void selectNodeContents(Node refNode) { }

        /// <summary>
        /// Compares the boundary points of two ranges.
        /// </summary>
        /// <param name="how">A value indicating how to compare.</param>
        /// <param name="sourceRange">The source range.</param>
        /// <returns>A number, -1 if before source, 0 if equal to source, +1 if after the source.</returns>
        public int compareBoundaryPoints(int how, Range sourceRange) { return 0; }
        
        /// <summary>
        /// Removes the contents of a Range from the document.
        /// </summary>
        public void deleteContents() { }

        /// <summary>
        /// Moves contents of a range from the document tree into a fragment.
        /// </summary>
        /// <returns>The newly created fragment.</returns>
        public DocumentFragment extractContents() { return null; }

        /// <summary>
        /// Returns a fragment copying the nodes of a Range.
        /// </summary>
        /// <returns>The newly created fragment.</returns>
        public DocumentFragment cloneContents() { return null; }

        /// <summary>
        /// Inserts a node at the start of a range.
        /// </summary>
        /// <param name="newNode">The node to insert.</param>
        public void insertNode(Node newNode) { }

        /// <summary>
        /// Moves the content of a range into a new node.
        /// </summary>
        /// <param name="newParent">The new parent node.</param>
        public void surroundContents(Node newParent) { }

        /// <summary>
        /// Returns a range object with boundary points identical to the cloned range.
        /// </summary>
        /// <returns>The newly created range.</returns>
        public Range cloneRange() { return null; }

        /// <summary>
        /// Releases the range from use.
        /// </summary>
        public void detach() { }
    }
}