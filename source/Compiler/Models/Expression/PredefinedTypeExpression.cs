using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a predefined type expression.
    /// </summary>
    public sealed class PredefinedTypeExpression : SymbolicExpression
    {
        /// <summary>
        /// Gets or sets the predefined type kind.
        /// </summary>
        public PredefinedType Kind { get; set; }
    }
}
