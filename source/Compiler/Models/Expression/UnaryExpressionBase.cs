
namespace Blade.Compiler.Models
{
    /// <summary>
    /// The base for prefix and postfix unary expressions.
    /// </summary>
    public abstract class UnaryExpressionBase : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the expression being prefixed.
        /// </summary>
        public virtual ExpressionModel Operand { get; set; }

        /// <summary>
        /// Gets or sets the operator text.
        /// </summary>
        public virtual string Operator { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// Prevents external inheritance.
        /// </summary>
        internal UnaryExpressionBase()
        {
        }
    }
}
