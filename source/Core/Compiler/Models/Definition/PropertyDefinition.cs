using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    public sealed class PropertyDefinition : MemberDefinition<IPropertySymbol>
    {
        private ITypeDefinition _type;

        /// <summary>
        /// Gets or sets the property type.
        /// </summary>
        public ITypeDefinition Type
        {
            get
            {
                if (_type == null)
                    _type = ModelRegistry.Current.GetDefinition<ITypeDefinition>(Symbol.Type);

                return _type;
            }
            set { _type = value; }
        }

        /// <summary>
        /// Creates a property definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public PropertyDefinition(IPropertySymbol symbol = null)
            : base(symbol)
        {
            MemberKind = MemberDefinitionKind.Property;
        }
    }
}
