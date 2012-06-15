using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a delegate definition.
    /// </summary>
    public sealed class DelegateDefinition : TypeDefinition<ITypeSymbol>
    {
        /// <summary>
        /// Creates a new delegate defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public DelegateDefinition(ITypeSymbol symbol = null)
            : base(symbol)
        {
            TypeKind = TypeDefinitionKind.Delegate;
        }
    }
}
