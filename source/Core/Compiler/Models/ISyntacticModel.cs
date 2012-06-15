using System;
using Roslyn.Compilers;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Data contract for a model that may have an associated location in source code.
    /// </summary>
    public interface ISyntacticModel : IModel
    {
        /// <summary>
        /// Gets or sets the tree that produced the model.
        /// </summary>
        CommonSyntaxTree OriginatingTree { get; set; }

        /// <summary>
        /// Gets or sets the node that produced the model.
        /// </summary>
        CommonSyntaxNode OriginatingNode { get; set; }
    }
}
