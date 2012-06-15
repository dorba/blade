
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents the possible literal expression types.
    /// </summary>
    public enum LiteralType
    {
        /// <summary>
        /// Indicates an unspecified type.
        /// </summary>
        None,

        /// <summary>
        /// Indicates the literal is a character.
        /// </summary>
        Character,

        /// <summary>
        /// Indicates the literal is a string.
        /// </summary>
        String,

        /// <summary>
        /// Indicates the literal is a number.
        /// </summary>
        Number,

        /// <summary>
        /// Indicates the literal is either the true or false keyword.
        /// </summary>
        Boolean,

        /// <summary>
        /// Indicates the literal is the null keyword.
        /// </summary>
        Null
    }
}
