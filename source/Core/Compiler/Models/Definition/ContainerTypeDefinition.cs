using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Base for class and struct definitions.
    /// </summary>
    public abstract class ContainerTypeDefinition : TypeDefinition<INamedTypeSymbol>
    {
        private List<ConstructorDefinition> _constructors;
        private List<FieldDefinition> _fields;
        private List<PropertyDefinition> _properties;
        private List<MethodDefinition> _methods;
        private List<ITypeDefinition> _interfaces;

        /// <summary>
        /// Gets the constructor definitions.
        /// </summary>
        public IList<ConstructorDefinition> Constructors
        {
            get
            {
                if (_constructors == null)
                {
                    _constructors = new List<ConstructorDefinition>();

                    if (Symbol != null)
                    {
                        var ctors = Symbol.GetMembers().OfType<IMethodSymbol>()
                            .Where(s => s.MethodKind == CommonMethodKind.Constructor);

                        foreach (var item in ctors)
                            _constructors.Add(ModelRegistry.Current.GetDefinition<ConstructorDefinition>(item));
                    }
                }

                return _constructors;
            }
        }

        /// <summary>
        /// Gets the field definitions.
        /// </summary>
        public IList<FieldDefinition> Fields
        {
            get
            {
                if (_fields == null)
                {
                    _fields = new List<FieldDefinition>();

                    if (Symbol != null)
                    {
                        var fields = Symbol.GetMembers().OfType<IFieldSymbol>();

                        foreach (var item in fields)
                            _fields.Add(ModelRegistry.Current.GetDefinition<FieldDefinition>(item));
                    }

                }

                return _fields;
            }
        }

        /// <summary>
        /// Gets the property definitions.
        /// </summary>
        public IList<PropertyDefinition> Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new List<PropertyDefinition>();

                    if (Symbol != null)
                    {
                        var properties = Symbol.GetMembers().OfType<IPropertySymbol>();

                        foreach (var item in properties)
                            _properties.Add(ModelRegistry.Current.GetDefinition<PropertyDefinition>(item));
                    }
                }

                return _properties;
            }
        }

        /// <summary>
        /// Gets the method definitions.
        /// </summary>
        public IList<MethodDefinition> Methods
        {
            get
            {
                if (_methods == null)
                {
                    _methods = new List<MethodDefinition>();

                    if (Symbol != null)
                    {
                        var methods = Symbol.GetMembers().OfType<IMethodSymbol>()
                            .Where(s => s.MethodKind == CommonMethodKind.Ordinary);

                        foreach (var item in methods)
                            _methods.Add(ModelRegistry.Current.GetDefinition<MethodDefinition>(item));
                    }
                }

                return _methods;
            }
        }

        /// <summary>
        /// Gets the interface definitions.
        /// </summary>
        public IList<ITypeDefinition> Interfaces
        {
            get
            {
                if (_interfaces == null)
                {
                    _interfaces = new List<ITypeDefinition>();

                    if (Symbol != null)
                    {
                        foreach (var item in Symbol.AllInterfaces)
                            _interfaces.Add(ModelRegistry.Current.GetDefinition<ITypeDefinition>(item));
                    }
                }

                return _interfaces;
            }
        }

        /// <summary>
        /// Creates a new container type defintion.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public ContainerTypeDefinition(INamedTypeSymbol symbol = null)
            : base(symbol)
        {
        }
    }
}
