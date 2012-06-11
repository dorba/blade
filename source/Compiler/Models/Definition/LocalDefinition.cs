using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    public sealed class LocalDefinition : Definition<ILocalSymbol>
    {
        private ITypeDefinition _type;

        /// <summary>
        /// Gets or sets the variable type.
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
        /// Creates a new local variable defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public LocalDefinition(ILocalSymbol symbol = null)
            : base(symbol)
        {
            Kind = DefinitionKind.Local;
        }
    }
}
