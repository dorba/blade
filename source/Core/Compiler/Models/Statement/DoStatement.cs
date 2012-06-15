using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a do-while loop statement.
    /// </summary>
    public sealed class DoStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the inner statement.
        /// </summary>
        public StatementModel Statement { get; set; }

        /// <summary>
        /// Gets or sets the loop condition.
        /// </summary>
        public ExpressionModel Condition { get; set; }
    }
}
