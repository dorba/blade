using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a for loop statement.
    /// </summary>
    public sealed class ForStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the inner statement.
        /// </summary>
        public StatementModel Statement { get; set; }

        /// <summary>
        /// Gets or sets the loop variable declaration.
        /// </summary>
        public VariableDeclaration VariableDeclaration { get; set; }

        /// <summary>
        /// Gets or sets the loop condition.
        /// </summary>
        public ExpressionModel Condition { get; set; }

        /// <summary>
        /// Gets the loop incrementor expressions.
        /// </summary>
        public IList<ExpressionModel> Incrementors
        {
            get { return _incrementors; }
        } private List<ExpressionModel> _incrementors;

        /// <summary>
        /// Gets the loop initializer expressions.
        /// </summary>
        public IList<ExpressionModel> Initializers
        {
            get { return _initializers; }
        } private List<ExpressionModel> _initializers;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ForStatement()
        {
            _incrementors = new List<ExpressionModel>();
            _initializers = new List<ExpressionModel>();
        }
    }
}
