using System.Collections.Generic;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// The base for method and constructor definitions.
    /// </summary>
    public abstract class BaseMethodDefinition : MemberDefinition<IMethodSymbol>
    {
        private List<ParameterDefinition> _parameters;

        /// <summary>
        /// Gets the method parameters.
        /// </summary>
        public IList<ParameterDefinition> Parameters
        {
            get
            {
                if (_parameters == null)
                {
                    _parameters = new List<ParameterDefinition>();

                    if (Symbol != null && Symbol.Parameters != null)
                    {
                        foreach (var param in Symbol.Parameters)
                            _parameters.Add(ModelRegistry.Current.GetDefinition<ParameterDefinition>(param));
                    }
                }

                return _parameters;
            }
        }

        /// <summary>
        /// Creates a method definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="provider">The definition provider.</param>
        public BaseMethodDefinition(IMethodSymbol symbol = null)
            : base(symbol)
        {
        }
    }
}
