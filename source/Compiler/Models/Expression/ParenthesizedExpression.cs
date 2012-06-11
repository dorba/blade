
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an expression enclosed by parenthesis.
    /// </summary>
    public sealed class ParenthesizedExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the inner expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }
    }
}
