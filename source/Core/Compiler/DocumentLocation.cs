using Roslyn.Compilers;
using Roslyn.Compilers.Common;

namespace Blade.Compiler
{
    /// <summary>
    /// Represents an text span associated with compilation message.
    /// </summary>
    public struct DocumentLocation
    {
        /// <summary>
        /// The starting line number.
        /// </summary>
        public int LineStart;

        /// <summary>
        /// The starting column number.
        /// </summary>
        public int ColumnStart;

        /// <summary>
        /// The ending line number.
        /// </summary>
        public int LineEnd;

        /// <summary>
        /// The ending column number.
        /// </summary>
        public int ColumnEnd;

        /// <summary>
        /// Gets a default location struct
        /// </summary>
        internal static DocumentLocation Default = new DocumentLocation
        {
            LineStart = -1,
            LineEnd = -1,
            ColumnStart = -1,
            ColumnEnd = -1
        };

        /// <summary>
        /// Gets a document location from a line span.
        /// </summary>
        /// <param name="span">The line span.</param>
        /// <returns>A new document location.</returns>
        internal static DocumentLocation FromSpan(FileLinePositionSpan span)
        {
            return new DocumentLocation
            {
                LineStart = span.StartLinePosition.Line + 1,
                ColumnStart = span.StartLinePosition.Character + 1,
                LineEnd = span.EndLinePosition.Line + 1,
                ColumnEnd = span.EndLinePosition.Character + 1
            };
        }

        /// <summary>
        /// Gets a document location from a tree node.
        /// </summary>
        /// <param name="tree">The tree.</param>
        /// <param name="node">The node.</param>
        /// <returns>A new document location.</returns>
        internal static DocumentLocation FromTreeNode(CommonSyntaxTree tree, CommonSyntaxNode node)
        {
            if (tree == null || node == null)
                return Default;

            return FromSpan(tree.GetLineSpan(node.Span, true));
        }
    }
}