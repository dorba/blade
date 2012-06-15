using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a dynamic type definition.
    /// </summary>
    public sealed class DynamicTypeDefinition : TypeDefinition<IDynamicTypeSymbol>
    {
        /// <summary>
        /// Creates a new dynamic type defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public DynamicTypeDefinition(IDynamicTypeSymbol symbol = null)
            : base(symbol)
        {
            TypeKind = TypeDefinitionKind.Dynamic;
        }
    }
}
