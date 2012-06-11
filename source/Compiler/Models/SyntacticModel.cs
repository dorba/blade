using System;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a syntatic model.
    /// </summary>
    public class SyntacticModel : ISyntacticModel
    {
        /// <summary>
        /// Gets or sets the tree that produced the model.
        /// </summary>
        public CommonSyntaxTree OriginatingTree { get; set; }

        /// <summary>
        /// Gets or sets the node that produced the model.
        /// </summary>
        public CommonSyntaxNode OriginatingNode { get; set; }
    }
}
