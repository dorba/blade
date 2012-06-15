using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a default type expression.
    /// </summary>
    public sealed class DefaultExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the target expression.
        /// </summary>
        public ITypeDefinition Type { get; set; }
    }
}
