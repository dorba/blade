using System;
using Blade.Compiler.Models;
using Roslyn.Compilers.Common;

namespace Blade.Compiler
{
    /// <summary>
    /// Represents an exception that occurs during the compilation process.
    /// </summary>
    public class CompilationException : Exception
    {
        /// <summary>
        /// Gets the related syntax node.
        /// </summary>
        public CommonSyntaxNode RelatedNode { get; private set; }

        /// <summary>
        /// Gets the related syntax tree.
        /// </summary>
        public CommonSyntaxTree RelatedTree { get; private set; }

        /// <summary>
        /// Creates a new exception.
        /// </summary>
        public CompilationException()
            : base("An unexpected error occurred. No location information is available.")
        {
        }

        /// <summary>
        /// Creates a new exception, with a specific message.
        /// </summary>
        /// <param name="message">The error message.</param>
        public CompilationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Creates a new exception, from a syntactic model.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="model">The model.</param>
        public CompilationException(string message, ISyntacticModel model)
            : base(message)
        {
            if (model != null)
            {
                RelatedNode = model.OriginatingNode;
                RelatedTree = model.OriginatingTree;
            }
        }

        /// <summary>
        /// Creates a new exception, with a locatable message.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="node">The related syntax node.</param>
        /// <param name="tree">The related syntax tree.</param>
        public CompilationException(string message, CommonSyntaxNode node, CommonSyntaxTree tree)
            : base(message)
        {
            RelatedNode = node;
            RelatedTree = tree;
        }

        /// <summary>
        /// Gets a compilation error message from the exception.
        /// </summary>
        /// <returns>A new compilation message.</returns>
        public CompilationMessage ToErrorMessage()
        {
            var message = new CompilationMessage { Message = base.Message };

            if (RelatedNode != null && RelatedTree != null)
            {
                message.FilePath = RelatedTree.FilePath;
                message.Location = DocumentLocation.FromTreeNode(RelatedTree, RelatedNode);
            }

            return message;
        }
    }
}
