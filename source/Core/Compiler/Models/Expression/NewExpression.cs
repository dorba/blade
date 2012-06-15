using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an object creation expression.
    /// </summary>
    public sealed class NewExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the type being created.
        /// </summary>
        public ITypeDefinition Type { get; set; }

        /// <summary>
        /// Gets or sets the constructor args.
        /// </summary>
        public IList<Argument> Arguments
        {
            get { return _parameters; }
        } private List<Argument> _parameters;

        /// <summary>
        /// Gets or sets the initializer expression.
        /// </summary>
        public InitializerExpression Initializer { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the expression has any args.
        /// </summary>
        public bool HasArguments
        {
            get { return Arguments != null && Arguments.Any(); }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public NewExpression()
        {
            _parameters = new List<Argument>();
        }
    }
}
