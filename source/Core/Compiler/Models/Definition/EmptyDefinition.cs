using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// An empty definition.
    /// </summary>
    /// <typeparam name="T">The symbol type.</typeparam>
    public class EmptyDefinition : IDefinition
    {
        /// <summary>
        /// Gets or sets the definition kind.
        /// </summary>
        public DefinitionKind Kind { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the associated symbol.
        /// </summary>
        public ISymbol Symbol { get; set; }

        /// <summary>
        /// Gets or sets the modifiers.
        /// </summary>
        public ModifierOptions Modifiers { get; set; }
    }
}
