
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an enum member declaration.
    /// </summary>
    public sealed class EnumMemberDeclaration : MemberDeclarationModel<EnumMemberDefinition>
    {
        /// <summary>
        /// Gets or sets an optional explicit value applied to the enum member.
        /// </summary>
        public ExpressionModel Value { get; set; }
    }
}
