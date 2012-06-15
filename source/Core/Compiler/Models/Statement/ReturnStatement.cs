
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a return statement.
    /// </summary>
    public sealed class ReturnStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the return expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }
    }
}
