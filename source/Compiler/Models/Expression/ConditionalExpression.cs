using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a conditional expression.
    /// </summary>
    public sealed class ConditionalExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the condition expression.
        /// </summary>
        public ExpressionModel Condition { get; set; }

        /// <summary>
        /// Gets or sets the expression for a true condition.
        /// </summary>
        public ExpressionModel TrueExpression { get; set; }

        /// <summary>
        /// Gets or sets the expression for a false condition.
        /// </summary>
        public ExpressionModel FalseExpression { get; set; }
    }
}
