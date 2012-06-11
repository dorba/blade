using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an element access expression.
    /// </summary>
    public sealed class ElementAccessExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the bracketed args.
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
        /// Gets or sets the accessing expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ElementAccessExpression()
        {
            _arguments = new List<Argument>();
        }
    }
}
