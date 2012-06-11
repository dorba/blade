using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an ordinary method definition.
    /// </summary>
    public sealed class MethodDefinition : BaseMethodDefinition
    {
        private ITypeDefinition _returnType;

        /// <summary>
        /// Gets or sets the return type.
        /// </summary>
        public ITypeDefinition ReturnType
        {
            get
            {
                if (_returnType == null && Symbol != null && !Symbol.ReturnsVoid)
                    _returnType = ModelRegistry.Current.GetDefinition<ITypeDefinition>(Symbol.ReturnType);

                return _returnType;
            }
            set { _returnType = value; }
        }

        /// <summary>
        /// Creates a method definition.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="provider">The definition provider.</param>
        public MethodDefinition(IMethodSymbol symbol = null)
            : base(symbol)
        {
            MemberKind = MemberDefinitionKind.Method;
        }
    }
}
