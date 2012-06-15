using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a generic type definition.
    /// </summary>
    public sealed class GenericTypeDefinition : TypeDefinition<ITypeParameterSymbol>
    {
        /// <summary>
        /// Creates a new generic type defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public GenericTypeDefinition(ITypeParameterSymbol symbol = null)
            : base(symbol)
        {
            TypeKind = TypeDefinitionKind.Generic;
        }
    }
}
