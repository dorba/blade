using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an identifier assignment expression.
    /// </summary>
    public sealed class AssignmentExpression : BinaryExpressionBase
    {
        /// <summary>
        /// Gets or sets the identifier being assigned to.
        /// </summary>
        public IdentifierName Assignee { get; set; }
    }
}
