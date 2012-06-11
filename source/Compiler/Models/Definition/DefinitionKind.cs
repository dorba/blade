
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents the available kinds of definition types.
    /// </summary>
    public enum DefinitionKind
    {
        /// <summary>
        /// A namespace.
        /// </summary>
        Namespace = 0,

        /// <summary>
        /// A type definition.
        /// </summary>
        Type = 1,

        /// <summary>
        /// A member definition.
        /// </summary>
        Member = 2,

        /// <summary>
        /// A parameter definition.
        /// </summary>
        Parameter = 3,

        /// <summary>
        /// A local variable.
        /// </summary>
        Local = 4
    }
}