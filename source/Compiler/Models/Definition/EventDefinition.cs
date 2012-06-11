using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    public sealed class EventDefinition : MemberDefinition<IEventSymbol>
    {
        private ITypeDefinition _type;

        /// <summary>
        /// Gets or sets the event type.
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
        /// Creates an event definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public EventDefinition(IEventSymbol symbol = null)
            : base(symbol)
        {
            MemberKind = MemberDefinitionKind.Event;
        }
    }
}
