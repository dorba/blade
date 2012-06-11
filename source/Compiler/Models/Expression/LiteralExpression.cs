
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a literal expression.
    /// </summary>
    public sealed class LiteralExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the literal text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the literal expression type.
        /// </summary>
        public LiteralType Type { get; set; }
    }
}
