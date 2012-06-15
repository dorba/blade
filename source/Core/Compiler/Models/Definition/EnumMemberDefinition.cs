using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an enum member definition.
    /// </summary>
    public sealed class EnumMemberDefinition : MemberDefinition<IFieldSymbol>
    {
        /// <summary>
        /// Creates a new enum member defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public EnumMemberDefinition(IFieldSymbol symbol = null)
            : base(symbol)
        {
            MemberKind = MemberDefinitionKind.EnumMember;
        }
    }
}
