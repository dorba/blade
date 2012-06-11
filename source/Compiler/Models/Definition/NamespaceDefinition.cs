using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a namespace.
    /// </summary>
    public class NamespaceDefinition : Definition<INamespaceSymbol>
    {
        /// <summary>
        /// Creates an empty namespace definition.
        /// </summary>
        public NamespaceDefinition()
        {
        }

        /// <summary>
        /// Creates a namespace definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public NamespaceDefinition(INamespaceSymbol symbol = null)
            : base(symbol)
        {
            Kind = DefinitionKind.Namespace;
        }
    }
}