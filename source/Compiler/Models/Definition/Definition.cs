using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Base implementation for a definition.
    /// </summary>
    /// <typeparam name="T">The symbol type.</typeparam>
    public abstract class Definition<T> : IDefinition
        where T : class, ISymbol
    {
        private T _symbol;

        /// <summary>
        /// Gets or sets the definition kind.
        /// </summary>
        public DefinitionKind Kind { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the modifier options.
        /// </summary>
        public ModifierOptions Modifiers { get; private set; }

        /// <summary>
        /// The associated symbol.
        /// </summary>
        public T Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        // explicit interface implementation.
        ISymbol IDefinition.Symbol
        {
            get { return Symbol; }
            set { Symbol = value as T; }
        }

        /// <summary>
        /// Creates a new definition.
        /// </summary>
        /// <param name="symbol">The associated symbol.</param>
        /// <param name="provider">The definition provider.</param>
        public Definition(T symbol = null)
        {
            Modifiers = new ModifierOptions();

            if (symbol != null)
            {
                // set data
                _symbol = symbol;
                Name = _symbol.Name;
                Modifiers.Access = GetAccessibility(_symbol);
                Modifiers.IsAbstract = _symbol.IsAbstract;
                Modifiers.IsExtern = _symbol.IsExtern;
                Modifiers.IsStatic = _symbol.IsStatic;
            }
        }

        // gets model accessibility from a symbol
        private static Accessibility GetAccessibility(ISymbol symbol)
        {
            if (symbol == null)
                return Accessibility.Internal;

            switch (symbol.DeclaredAccessibility)
            {
                case CommonAccessibility.Private: return Accessibility.Private;
                case CommonAccessibility.Public: return Accessibility.Public;

                case CommonAccessibility.Protected:
                case CommonAccessibility.ProtectedAndInternal:
                case CommonAccessibility.ProtectedOrInternal:
                    return Accessibility.Protected;

                default:
                    return Accessibility.Internal;
            }
        }
    }
}
