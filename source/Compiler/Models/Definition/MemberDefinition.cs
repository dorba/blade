using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Base implementation for member definition.
    /// </summary>
    /// <typeparam name="T">The symbol type.</typeparam>
    public abstract class MemberDefinition<T> : Definition<T>, IMemberDefinition
        where T : class, ISymbol
    {
        private ITypeDefinition _containingType;

        /// <summary>
        /// Gets or sets the member definition kind.
        /// </summary>
        public MemberDefinitionKind MemberKind { get; set; }

        /// <summary>
        /// Gets or sets the containing type.
        /// </summary>
        public ITypeDefinition ContainingType
        {
            get
            {
                if (_containingType == null && Symbol != null && Symbol.ContainingType != null)
                    _containingType = ModelRegistry.Current.GetDefinition<ITypeDefinition>(Symbol.ContainingType);

                return _containingType;
            }
            set { _containingType = value; }
        }

        /// <summary>
        /// Creates a member definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public MemberDefinition(T symbol = null)
            : base(symbol)
        {
            Kind = DefinitionKind.Member;
        }
    }
}
