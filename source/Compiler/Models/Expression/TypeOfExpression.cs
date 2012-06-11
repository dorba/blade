
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a type request expression.
    /// </summary>
    public sealed class TypeOfExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the target of the type request invocation.
        /// </summary>
        public ITypeDefinition Target { get; set; }
    }
}
