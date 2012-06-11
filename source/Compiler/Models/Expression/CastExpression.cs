using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a cast expression.
    /// </summary>
    public sealed class CastExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the type being cased to.
        /// </summary>
        public ITypeDefinition CastingType { get; set; }

        /// <summary>
        /// Gets or sets the expression being casted.
        /// </summary>
        public ExpressionModel Expression { get; set; }
    }
}
