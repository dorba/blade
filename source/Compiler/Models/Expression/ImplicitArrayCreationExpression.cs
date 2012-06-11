using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an implicit array creation expression.
    /// </summary>
    public sealed class ImplicitArrayCreationExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the initializer expression.
        /// </summary>
        public InitializerExpression Initializer { get; set; }
    }
}
