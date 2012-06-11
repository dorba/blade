//----------------------------------------------
// Created from April 2012 DOM specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// An object able to describe filtered nodes for use when traversing a tree.
    /// </summary>
    [ScriptName("Object")]
    public abstract class NodeFilter
    {
        /// <summary>
        /// The node is accepted by the filter.
        /// </summary>
        public const int FILTER_ACCEPT = 1;

        /// <summary>
        /// The node is rejected by the filter.
        /// </summary>
        public const int FILTER_REJECT = 2;

        /// <summary>
        /// The node is skipped by the filter.
        /// </summary>
        public const int FILTER_SKIP = 3;

        /// <summary>
        /// Show all nodes.
        /// </summary>
        public const int SHOW_ALL = 0x00000000;

        /// <summary>
        /// Show element nodes.
        /// </summary>
        public const int SHOW_ELEMENT = 0x00000001;

        /// <summary>
        /// Show attribute nodes.
        /// </summary>
        public const int SHOW_ATTRIBUTE = 0x00000002;

        /// <summary>
        /// Show text nodes.
        /// </summary>
        public const int SHOW_TEXT = 0x00000004;

        /// <summary>
        /// Show CDATA section nodes.
        /// </summary>
        public const int SHOW_CDATA_SECTION = 0x00000008;

        /// <summary>
        /// Show entity reference nodes.
        /// </summary>
        public const int SHOW_ENTITY_REFERENCE = 0x00000010;

        /// <summary>
        /// Show entity nodes.
        /// </summary>
        public const int SHOW_ENTITY = 0x00000020;

        /// <summary>
        /// Show processing instruction nodes.
        /// </summary>
        public const int SHOW_PROCESSING_INSTRUCTION = 0x00000040;

        /// <summary>
        /// Show comment nodes.
        /// </summary>
        public const int SHOW_COMMENT = 0x00000080;

        /// <summary>
        /// Show document nodes.
        /// </summary>
        public const int SHOW_DOCUMENT = 0x00000100;

        /// <summary>
        /// Show document type nodes.
        /// </summary>
        public const int SHOW_DOCUMENT_TYPE = 0x00000200;

        /// <summary>
        /// Show document fragment nodes.
        /// </summary>
        public const int SHOW_DOCUMENT_FRAGMENT = 0x00000400;

        /// <summary>
        /// Show notation nodes.
        /// </summary>
        public const int SHOW_NOTATION = 0x00000800;

        /// <summary>
        /// Tests whether a specified node is visible in the logical view .
        /// </summary>
        /// <param name="n">The node to test.</param>
        /// <returns>An integer representing the node state.</returns>
        public abstract int acceptNode(Node n);
    }
}