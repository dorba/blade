
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an expression statement.
    /// </summary>
    public sealed class ExpressionStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }
    }
}
