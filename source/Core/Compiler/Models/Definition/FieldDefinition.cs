using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    public sealed class FieldDefinition : MemberDefinition<IFieldSymbol>
    {
        private ITypeDefinition _type;

        /// <summary>
        /// Gets or sets the field type.
        /// </summary>
        public ITypeDefinition Type
        {
            get
            {
                if (_type == null && Symbol != null && Symbol.Type != null)
                    _type = ModelRegistry.Current.GetDefinition<ITypeDefinition>(Symbol.Type);

                return _type;
            }
            set { _type = value; }
        }

        /// <summary>
        /// Creates a field definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public FieldDefinition(IFieldSymbol symbol = null)
            : base(symbol)
        {
            MemberKind = MemberDefinitionKind.Field;
        }
    }
}
