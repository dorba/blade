using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an array creation expression.
    /// </summary>
    public sealed class ArrayCreationExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the array type expression.
        /// </summary>
        public ArrayTypeExpression TypeExpression { get; set; }

        /// <summary>
        /// Gets or sets the initializer expression.
        /// </summary>
        public InitializerExpression Initializer { get; set; }
    }
}
