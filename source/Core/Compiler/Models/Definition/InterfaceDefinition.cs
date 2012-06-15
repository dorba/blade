using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an interface definition.
    /// </summary>
    public sealed class InterfaceDefinition : ContainerTypeDefinition
    {
        /// <summary>
        /// Creates a new interface defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public InterfaceDefinition(INamedTypeSymbol symbol = null)
            : base(symbol)
        {
            TypeKind = TypeDefinitionKind.Interface;
        }
    }
}
