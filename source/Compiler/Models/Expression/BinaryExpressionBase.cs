using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a binary expression.
    /// </summary>
    public abstract class BinaryExpressionBase : ExpressionModel
    {
        /// <summary>
        /// Gets or set the left expression.
        /// </summary>
        public virtual ExpressionModel LeftExpression { get; set; }

        /// <summary>
        /// Gets or sets the right expression.
        /// </summary>
        public virtual ExpressionModel RightExpression { get; set; }

        /// <summary>
        /// Gets or sets the operator text.
        /// </summary>
        public virtual string Operator { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// Prevents external inheritance.
        /// </summary>
        internal BinaryExpressionBase()
        {
        }
    }
}
