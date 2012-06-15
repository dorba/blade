using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a parameter definition.
    /// </summary>
    public sealed class ParameterDefinition : Definition<IParameterSymbol>
    {
        private ITypeDefinition _type;
        private bool? _hasDefaultValue;

        /// <summary>
        /// Gets or sets the parameter type definition.
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
        /// Gets or sets a value indicating if the parameter has a default value.
        /// </summary>
        public bool HasDefaultValue
        {
            get
            {
                if (!_hasDefaultValue.HasValue)
                {
                    _hasDefaultValue = Symbol.HasDefaultValue;
                }

                return _hasDefaultValue.Value;
            }
            set { _hasDefaultValue = value; }
        }

        /// <summary>
        /// Creates a new parameter definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public ParameterDefinition(IParameterSymbol symbol = null)
            : base(symbol)
        {
            Kind = DefinitionKind.Parameter;
        }
    }
}
