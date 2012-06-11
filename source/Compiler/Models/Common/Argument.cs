using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an argument in an invocation.
    /// </summary>
    public sealed class Argument : SyntacticModel
    {
        /// <summary>
        /// Gets or sets the argument expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }

        /// <summary>
        /// Gets or sets the named of the parameter being targeted.
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the argument targets a specific named parameter.
        /// </summary>
        public bool HasExplicitTarget
        {
            get { return !String.IsNullOrEmpty(ParameterName); }
        }
    }
}
