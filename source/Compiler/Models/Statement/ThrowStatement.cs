using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a throw statement.
    /// </summary>
    public sealed class ThrowStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the throw expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }
    }
}
