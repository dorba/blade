using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an array type definition.
    /// </summary>
    public sealed class ArrayTypeDefinition : TypeDefinition<IArrayTypeSymbol>
    {
        private ITypeDefinition _elementType;

        /// <summary>
        /// Gets or sets the element type.
        /// </summary>
        public ITypeDefinition ElementType
        {
            get
            {
                if (_elementType == null && Symbol != null && Symbol.ElementType != null)
                    _elementType = ModelRegistry.Current.GetDefinition<ITypeDefinition>(Symbol.ElementType);

                return _elementType;
            }
            set { _elementType = value; }
        }

        /// <summary>
        /// Creates a new array type defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public ArrayTypeDefinition(IArrayTypeSymbol symbol = null)
            : base(symbol)
        {
            TypeKind = TypeDefinitionKind.Array;
        }
    }
}
