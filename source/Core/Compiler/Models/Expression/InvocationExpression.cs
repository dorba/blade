using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an invocation expression.
    /// </summary>
    public sealed class InvocationExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the invocation args.
        /// </summary>
        public IList<Argument> Arguments
        {
            get { return _arguments; }
        } private List<Argument> _arguments;

        /// <summary>
        /// Gets a value indicating whether or not the expression has any args.
        /// </summary>
        public bool HasArguments
        {
            get { return Arguments != null && Arguments.Any(); }
        }

        /// <summary>
        /// Gets or sets the expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public InvocationExpression()
        {
            _arguments = new List<Argument>();
        }
    }
}
