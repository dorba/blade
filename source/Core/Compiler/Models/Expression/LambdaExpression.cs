using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a lambda expression.
    /// </summary>
    public sealed class LambdaExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the body of the lambda.
        /// </summary>
        public ISyntacticModel Body { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the method.
        /// </summary>
        public IList<ParameterDeclaration> Parameters
        {
            get { return _parameters; }
        } private List<ParameterDeclaration> _parameters;

        /// <summary>
        /// Gets a value indicating whether or not the lambda has any parameters.
        /// </summary>
        public bool HasParameters
        {
            get { return Parameters != null && Parameters.Any(); }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public LambdaExpression()
        {
            _parameters = new List<ParameterDeclaration>();
        }
    }
}
