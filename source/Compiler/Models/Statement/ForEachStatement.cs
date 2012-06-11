using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a foreach loop statement.
    /// </summary>
    public sealed class ForEachStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the inner statement.
        /// </summary>
        public StatementModel Statement { get; set; }

        /// <summary>
        /// Gets or sets the loop expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }

        /// <summary>
        /// Gets or sets the loop variable type.
        /// </summary>
        public ITypeDefinition Type { get; set; }

        /// <summary>
        /// Gets or sets the identifier name.
        /// </summary>
        public string IdentifierName { get; set; }
    }
}
