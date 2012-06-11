
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents the type accessibility modifier.
    /// </summary>
    public enum Accessibility
    {
        /// <summary>
        /// Assembly internal access.
        /// </summary>
        Internal = 0,

        /// <summary>
        /// Public access.
        /// </summary>
        Public = 1,

        /// <summary>
        /// Local type access.
        /// </summary>
        Private = 2,

        /// <summary>
        /// Local and derived type access.
        /// </summary>
        Protected = 3
    }
}
