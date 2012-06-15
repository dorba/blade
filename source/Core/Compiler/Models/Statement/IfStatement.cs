using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an if statement.
    /// </summary>
    public sealed class IfStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the condition expression.
        /// </summary>
        public ExpressionModel Condition { get; set; }

        /// <summary>
        /// Gets or sets the statement.
        /// </summary>
        public StatementModel Statement { get; set; }

        /// <summary>
        /// Gets or sets the optional else statement.
        /// </summary>
        public StatementModel ElseStatement { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the statment has an else statement.
        /// </summary>
        public bool HasElseStatement
        {
            get { return ElseStatement != null; }
        }

        /// <summary>
        /// Gets a value indicating whether or not the else statement is another <see cref="IfStatement"/>.
        /// </summary>
        public bool HasElseIfStatement
        {
            get { return HasElseStatement && ElseStatement is IfStatement; }
        }
    }
}
