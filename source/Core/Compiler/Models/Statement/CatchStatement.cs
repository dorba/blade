using System;
using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a catch statement.
    /// </summary>
    public sealed class CatchStatement : SyntacticModel
    {
        /// <summary>
        /// Gets or sets the catch statement body.
        /// </summary>
        public CodeBlock Body { get; set; }

        /// <summary>
        /// Gets or sets the type of exception to catch.
        /// </summary>
        public ITypeDefinition Type { get; set; }

        ///// <summary>
        ///// Gets or sets the identifier.
        ///// </summary>
        public IDefinition Identifier { get; set; }
    }
}
