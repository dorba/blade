using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a struct definition.
    /// </summary>
    public sealed class StructDefinition : ContainerTypeDefinition
    {
        /// <summary>
        /// Creates a new class defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public StructDefinition(INamedTypeSymbol symbol = null)
            : base(symbol)
        {
        }
    }
}
