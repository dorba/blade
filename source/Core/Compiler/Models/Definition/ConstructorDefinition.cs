using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a constructor definition.
    /// </summary>
    public sealed class ConstructorDefinition : BaseMethodDefinition
    {
        /// <summary>
        /// Creates a constructor definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public ConstructorDefinition(IMethodSymbol symbol)
            : base(symbol)
        {
            MemberKind = MemberDefinitionKind.Constructor;
        }
    }
}
