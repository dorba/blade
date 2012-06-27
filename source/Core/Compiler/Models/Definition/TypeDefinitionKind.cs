
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents the available kinds of type definition implementations.
    /// </summary>
    public enum TypeDefinitionKind
    {
        /// <summary>
        /// The type is a <see cref="ClassDefinition"/>.
        /// </summary>
        Class = 0,

        /// <summary>
        /// The type is an <see cref="InterfaceDefinition"/>.
        /// </summary>
        Interface = 1,

        /// <summary>
        /// The type is a <see cref="EnumDefinition"/>.
        /// </summary>
        Enum = 2,

        /// <summary>
        /// The type is a <see cref="StructDefinition"/>.
        /// </summary>
        Struct = 3,

        /// <summary>
        /// The type is a <see cref="ArrayTypeDefinition"/>.
        /// </summary>
        Array = 4,

        /// <summary>
        /// The type is a <see cref="GenericTypeDefinition"/>.
        /// </summary>
        Generic = 5,

        /// <summary>
        /// The type is a <see cref="DynamicTypeDefinition"/>.
        /// </summary>
        Dynamic = 6,

        /// <summary>
        /// The type is a <see cref="DelegateDefinition"/>
        /// </summary>
        Delegate = 7,

        /// <summary>
        /// The type is a <see cref="ITypeDefinition"/> forced into being viewed as anonymous.
        /// </summary>
        Anonymous = 8
    }
}
