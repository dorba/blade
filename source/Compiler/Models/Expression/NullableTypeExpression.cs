using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a nullable type expression.
    /// </summary>
    public sealed class NullableTypeExpression : SymbolicExpression
    {
        /// <summary>
        /// Gets or sets the inner type of the nullable expression.
        /// </summary>
        public ITypeDefinition InnerType { get; set; }
    }
}
