using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an anonymous method.
    /// </summary>
    public sealed class AnonymousMethodExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the parameters of the method.
        /// </summary>
        public IList<ParameterDeclaration> Parameters
        {
            get { return _parameters; }
        } private List<ParameterDeclaration> _parameters;

        /// <summary>
        /// Gets a value indicating whether or not the method has any parameters.
        /// </summary>
        public bool HasParameters
        {
            get { return Parameters != null && Parameters.Any(); }
        }

        /// <summary>
        /// Gets or sets the method body block.
        /// </summary>
        public CodeBlock Body { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public AnonymousMethodExpression()
        {
            _parameters = new List<ParameterDeclaration>();
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="parameters">The method parameters.</param>
        public AnonymousMethodExpression(params ParameterDeclaration[] parameters)
        {
            _parameters = new List<ParameterDeclaration>(parameters);
        }
    }
}
