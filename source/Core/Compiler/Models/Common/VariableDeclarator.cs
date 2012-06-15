using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an individual variable declaration.
    /// </summary>
    public sealed class VariableDeclarator : DeclarationModel<LocalDefinition>
    {
        /// <summary>
        /// Gets or sets the optional equals value expression.
        /// </summary>
        public ExpressionModel EqualsValueExpression { get; set; }
    }
}
