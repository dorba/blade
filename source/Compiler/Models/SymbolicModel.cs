using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a symbolic model, which has an associated symbol.
    /// </summary>
    /// <typeparam name="T">The definition type.</typeparam>
    public class SymbolicModel : IModel, ISymbolicModel
    {
        /// <summary>
        /// Explicit interface implementation.
        /// Gets the associated definition.
        /// </summary>
        public IDefinition Definition { get; set; }
    }
}
