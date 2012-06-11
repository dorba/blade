using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Roslyn.Compilers.Common;
using Blade.Compiler.Extensibility;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Provides storage and lookup of model definitions.
    /// </summary>
    internal sealed class ModelRegistry
    {
        private Dictionary<ISymbol, IDefinition> _lookup;
        private ExtensionFactory _extFactory;
        private static ModelRegistry _current;
        private static object _lock = new object();

        /// <summary>
        /// Gets the current registry context.
        /// </summary>
        public static ModelRegistry Current
        {
            get { return _current; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        private ModelRegistry()
        {
            _lookup = new Dictionary<ISymbol, IDefinition>();
        }

        /// <summary>
        /// Begins a new registration process.
        /// </summary>
        public static void BeginRegistration()
        {
            if (_current != null)
                throw new InvalidOperationException("An existing registration context is already open.");

            Monitor.Enter(_lock);

            _current = new ModelRegistry();
            _current._extFactory = new ExtensionFactory();
        }

        /// <summary>
        /// Ends the current registration process.
        /// </summary>
        /// <returns></returns>
        public static ModelRegistry EndRegistration()
        {
            var completed = _current;
            _current = null;

            Monitor.Exit(_lock);
            return completed;
        }

        /// <summary>
        /// Gets the definition from a symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>The associated definition.</returns>
        public IDefinition GetDefinition(ISymbol symbol)
        {
            if (symbol == null)
                throw new ArgumentNullException("symbol", "The symbol cannot be null.");

            if (_lookup.ContainsKey(symbol))
                return _lookup[symbol];

            var newDef = CreateDefinition(symbol);
            _lookup.Add(symbol, newDef);

            return newDef;
        }

        /// <summary>
        /// Gets the definition from a symbol.
        /// </summary>
        /// <typeparam name="T">The expected definition type.</typeparam>
        /// <param name="symbol">The symbol.</param>
        /// <returns>The associated definition.</returns>
        public T GetDefinition<T>(ISymbol symbol) where T : class, IDefinition
        {
            return GetDefinition(symbol) as T;
        }

        /// <summary>
        /// Gets all registered definitions.
        /// </summary>
        /// <returns>A collection of definitions.</returns>
        public IEnumerable<IDefinition> GetAllDefinitions()
        {
            return _lookup.Select(i => i.Value);
        }

        /// <summary>
        /// Runs extensions for all declarations in a model
        /// </summary>
        /// <param name="model">The target model.</param>
        /// <param name="asmSymbol">The associated symbol.</param>
        public void ExtendCompilation(CompilationModel model, IAssemblySymbol asmSymbol)
        {
            // apply compiling assembly extensions
            if (asmSymbol != null)
            {
                foreach (var ext in _extFactory.GetExtensions(asmSymbol))
                    ext.ExtendCompilation(model);
            }

            var allDecls = model.GetAllDeclarations().ToArray();

            // apply declaration extensions
            for (int i = 0; i < allDecls.Length; i++)
            {
                var decl = allDecls[i];
                if (decl.Definition == null || decl.Definition.Symbol == null)
                    continue;

                foreach (var ext in _extFactory.GetExtensions(decl.Definition.Symbol))
                {
                    ext.ExtendDeclaration(decl, model);
                }
            }
        }

        // creates a new model class, based on symbol properties
        private IDefinition CreateDefinition(ISymbol symbol)
        {
            IDefinition model;

            switch (symbol.Kind)
            {
                case CommonSymbolKind.Alias: model = CreateDefinition(((IAliasSymbol)symbol).Target); break;
                case CommonSymbolKind.NamedType: model = CreateTypeModel(symbol as ITypeSymbol); break;
                case CommonSymbolKind.Method: model = CreateMethodModel(symbol as IMethodSymbol); break;
                case CommonSymbolKind.Field: model = CreateFieldModel(symbol as IFieldSymbol); break;
                case CommonSymbolKind.Property: model = new PropertyDefinition(symbol as IPropertySymbol); break;
                case CommonSymbolKind.Parameter: model = new ParameterDefinition(symbol as IParameterSymbol); break;
                case CommonSymbolKind.Local: model = new LocalDefinition(symbol as ILocalSymbol); break;
                case CommonSymbolKind.ArrayType: model = new ArrayTypeDefinition(symbol as IArrayTypeSymbol); break;
                case CommonSymbolKind.Namespace: model = new NamespaceDefinition(symbol as INamespaceSymbol); break;
                case CommonSymbolKind.TypeParameter: model = new GenericTypeDefinition(symbol as ITypeParameterSymbol); break;
                case CommonSymbolKind.DynamicType: model = new DynamicTypeDefinition(symbol as IDynamicTypeSymbol); break;
                case CommonSymbolKind.Event: model = new EventDefinition(symbol as IEventSymbol); break;

                default:
                    throw new InvalidOperationException("Unable to create model from symbol: " + symbol.Kind);
            }

            if (model != null)
                ExtendDefinition(model);

            return model;
        }

        // creates a new type model class, based on the symbol's type kind
        private IDefinition CreateTypeModel(ITypeSymbol symbol)
        {
            switch (symbol.TypeKind)
            {
                case CommonTypeKind.Class: return new ClassDefinition(symbol as INamedTypeSymbol);
                case CommonTypeKind.Struct: return new StructDefinition(symbol as INamedTypeSymbol);
                case CommonTypeKind.Interface: return new InterfaceDefinition(symbol as INamedTypeSymbol);
                case CommonTypeKind.Enum: return new EnumDefinition(symbol as INamedTypeSymbol);
                case CommonTypeKind.Delegate: return new DelegateDefinition(symbol);

                default:
                    throw new InvalidOperationException("Unable to created type model from symbol: " + symbol.TypeKind);
            }
        }

        // creates a new method model class, based on the symbol's type kind
        private IDefinition CreateMethodModel(IMethodSymbol symbol)
        {
            switch (symbol.MethodKind)
            {
                case CommonMethodKind.Constructor: return new ConstructorDefinition(symbol);

                case CommonMethodKind.AnonymousFunction:
                case CommonMethodKind.Ordinary:
                case CommonMethodKind.ReducedExtension:
                case CommonMethodKind.ExplicitInterfaceImplementation:
                    return new MethodDefinition(symbol);

                default:
                    throw new InvalidOperationException("Unable to create method model from symbol: " + symbol.MethodKind);
            }
        }

        // creates a new field defintion, based on the symbol values
        private IDefinition CreateFieldModel(IFieldSymbol symbol)
        {
            if (symbol.ContainingType != null)
            {
                if (symbol.ContainingType.TypeKind == CommonTypeKind.Enum)
                    return new EnumMemberDefinition(symbol);
            }

            return new FieldDefinition(symbol);
        }

        // runs definition extensions
        private void ExtendDefinition(IDefinition definition)
        {
            if (definition == null || definition.Symbol == null)
                return;

            // execute assembly level extensions
            var asm = definition.Symbol.ContainingAssembly;
            if (asm != null)
            {
                foreach (var ext in _extFactory.GetExtensions(asm))
                    ext.ExtendDefinition(definition);
            }

            // execute target level extensions
            foreach (var ext in _extFactory.GetExtensions(definition.Symbol))
            {
                ext.ExtendDefinition(definition);
            }
        }
    }
}
