using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Provides methods for importing and resolving translators by model type.
    /// </summary>
    internal sealed class TranslatorProvider : GenericImportProvider<ITranslator>
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="importAssemblies">The reference assemblies to import against.</param>
        public TranslatorProvider(IEnumerable<Assembly> importAssemblies = null)
            : base(importAssemblies)
        {
        }

        /// <summary>
        /// Gets the generic base type definition.
        /// </summary>
        protected override Type BaseType
        {
            get { return typeof(Translator<>); }
        }
    }
}
