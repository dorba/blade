
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an explicit base call.
    /// </summary>
    public sealed class BaseExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the type which is calling the base expression.
        /// </summary>
        public ITypeDefinition CallingType { get; set; }

        /// <summary>
        /// Gets or set the type of the base class being called.
        /// </summary>
        public ITypeDefinition BaseType { get; set; }
    }
}
