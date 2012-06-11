using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Base implementation for type definition.
    /// </summary>
    /// <typeparam name="T">The symbol type.</typeparam>
    public abstract class TypeDefinition<T> : Definition<T>, ITypeDefinition
        where T : class, ISymbol
    {
        /// <summary>
        /// Gets or sets the type definition kind.
        /// </summary>
        public TypeDefinitionKind TypeKind { get; set; }

        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Creates a type definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public TypeDefinition(T symbol = null)
            : base(symbol)
        {
            Kind = DefinitionKind.Type;

            if (symbol != null)
                Namespace = symbol.GetFullNamespace();
        }
    }
}
