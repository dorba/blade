using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a local variable declaration.
    /// </summary>
    public sealed class LocalDeclarationStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the variable declaration model.
        /// </summary>
        public VariableDeclaration VariableDeclaration { get; set; }
    }
}
