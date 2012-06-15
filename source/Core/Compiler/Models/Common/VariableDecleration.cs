using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a collection of variable declarations.
    /// </summary>
    public sealed class VariableDeclaration : SyntacticModel
    {
        /// <summary>
        /// Gets the variable type.
        /// </summary>
        public ITypeDefinition Type
        {
            get { return Variables.Any() ? Variables[0].Definition.Type : null; }
        }

        /// <summary>
        /// Gets all variables declared in the declaration.
        /// </summary>
        public IList<VariableDeclarator> Variables
        {
            get { return _variables; }
        } private List<VariableDeclarator> _variables;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public VariableDeclaration()
        {
            _variables = new List<VariableDeclarator>();
        }
    }
}
