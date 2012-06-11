using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a qualified name expression
    /// </summary>
    public sealed class QualifiedName : ExpressionModel
    {
        /// <summary>
        /// Gets or sets left name.
        /// </summary>
        public IdentifierName LeftName { get; set; }

        /// <summary>
        /// Gets or sets the right name.
        /// </summary>
        public IdentifierName RightName { get; set; }
    }
}
