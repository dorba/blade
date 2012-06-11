using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// The data contract for any definition model.
    /// </summary>
    public interface IDefinition
    {
        /// <summary>
        /// Gets or sets the definition kind.
        /// </summary>
        DefinitionKind Kind { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the associated symbol.
        /// </summary>
        ISymbol Symbol { get; set; }

        /// <summary>
        /// Gets the modifier options.
        /// </summary>
        ModifierOptions Modifiers { get; }
    }
}
