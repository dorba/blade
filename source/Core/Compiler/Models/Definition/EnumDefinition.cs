using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an enum definition.
    /// </summary>
    public sealed class EnumDefinition : TypeDefinition<INamedTypeSymbol>
    {
        /// <summary>
        /// Creates a new enum defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public EnumDefinition(INamedTypeSymbol symbol = null)
            : base(symbol)
        {
            TypeKind = TypeDefinitionKind.Enum;
        }
    }
}
