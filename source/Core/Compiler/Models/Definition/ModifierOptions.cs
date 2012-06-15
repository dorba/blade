
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents modifier options for a declaration.
    /// </summary>
    public sealed class ModifierOptions
    {
        /// <summary>
        /// Gets or sets the declared accessibility.
        /// </summary>
        public Accessibility Access { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the declaration is abstract.
        /// </summary>
        public bool IsAbstract { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the declaration is external.
        /// </summary>
        public bool IsExtern { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the declaration is static.
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// Sets the modifier options from another set of options.
        /// </summary>
        /// <param name="options">The options.</param>
        public void Apply(ModifierOptions options)
        {
            if (options == null)
                return;

            Access = options.Access;
            IsAbstract = options.IsAbstract;
            IsExtern = options.IsExtern;
            IsStatic = options.IsStatic;
        }
    }
}
