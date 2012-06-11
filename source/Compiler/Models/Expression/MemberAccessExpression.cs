using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a member access expression.
    /// </summary>
    public sealed class MemberAccessExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or set the access expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }

        /// <summary>
        /// Gets or sets the member being accessed.
        /// </summary>
        public IdentifierName Member { get; set; }
    }
}
