
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a parameter declaration.
    /// </summary>
    public sealed class ParameterDeclaration : DeclarationModel<ParameterDefinition>
    {
        /// <summary>
        /// Gets or sets the default value expression.
        /// </summary>
        public ExpressionModel DefaultExpression { get; set; }
    }
}
