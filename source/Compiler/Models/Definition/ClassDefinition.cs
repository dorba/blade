using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a class definition.
    /// </summary>
    public sealed class ClassDefinition : ContainerTypeDefinition
    {
        private ClassDefinition _baseClass;

        public ClassDefinition BaseClass
        {
            get
            {
                if (_baseClass == null && Symbol != null)
                {
                    if (Symbol.BaseType == null)
                        return null;

                    _baseClass = ModelRegistry.Current.GetDefinition<ClassDefinition>(Symbol.BaseType);
                }

                return _baseClass;
            }
            set { _baseClass = value; }
        }

        /// <summary>
        /// Creates a new class defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public ClassDefinition(INamedTypeSymbol symbol = null)
            : base(symbol)
        {
            TypeKind = TypeDefinitionKind.Class;
        }
    }
}
