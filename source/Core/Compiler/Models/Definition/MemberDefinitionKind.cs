
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents the avaialable kinds of member definition implementations.
    /// </summary>
    public enum MemberDefinitionKind
    {
        /// <summary>
        /// The member is a <see cref="ConstructorDefinition"/>.
        /// </summary>
        Constructor = 0,

        /// <summary>
        /// The member is a <see cref="MethodDefinition"/>.
        /// </summary>
        Method = 1,

        /// <summary>
        /// The member is a <see cref="PropertyDefinition"/>.
        /// </summary>
        Property = 2,

        /// <summary>
        /// The member is a <see cref="FieldDefinition"/>.
        /// </summary>
        Field = 3,

        /// <summary>
        /// The member is a <see cref="EventDefinition"/>.
        /// </summary>
        Event = 4,

        /// <summary>
        /// The member is a <see cref="EnumMemberDefinition"/>.
        /// </summary>
        EnumMember = 5
    }
}