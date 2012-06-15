using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blade.Compiler
{
    /// <summary>
    /// Internal helper class for resolving imports associated with a specific generic type arg.
    /// </summary>
    /// <typeparam name="T">The imported type.</typeparam>
    internal abstract class GenericImportProvider<T> : ImportProvider<T>
        where T : class
    {
        private Dictionary<Type, T> _lookupTable;

        /// <summary>
        /// Gets the generic base type from the derived class.
        /// </summary>
        protected abstract Type BaseType { get; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="importAssemblies">The reference assemblies to import against.</param>
        public GenericImportProvider(IEnumerable<Assembly> importAssemblies = null)
            : base(importAssemblies)
        {
            _lookupTable = new Dictionary<Type, T>();

            foreach (var item in GetImports())
            {
                var targetType = GetTargetType(item);
                if (targetType == null)
                    continue;

                if (!_lookupTable.ContainsKey(targetType))
                    _lookupTable.Add(targetType, item);
            }
        }

        /// <summary>
        /// Resolves a single import by type.
        /// </summary>
        /// <param name="targetType">The target type.</param>
        /// <returns>The associated import.</returns>
        public T ResolveImport(Type targetType)
        {
            if (_lookupTable.ContainsKey(targetType))
                return _lookupTable[targetType];

            return null;
        }

        // gets the generic type arg for the import
        private Type GetTargetType(T obj)
        {
            if (obj == null)
                return null;

            var type = obj.GetType();
            var found = false;

            while (type != null && type != typeof(object))
            {
                if (type.IsGenericType)
                {
                    if (type.GetGenericTypeDefinition() == BaseType)
                    {
                        found = true;
                        break;
                    }
                }

                type = type.BaseType;
            }

            if (!found)
                return null;

            return type.GetGenericArguments()[0];
        }
    }
}
