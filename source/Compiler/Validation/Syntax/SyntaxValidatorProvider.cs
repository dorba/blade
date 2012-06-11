using System;
using System.Collections.Generic;
using System.Reflection;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Import provider implementation for syntax validators.
    /// </summary>
    internal sealed class SyntaxValidatorProvider : GenericImportProvider<ISyntaxValidator>
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="importAssemblies">The reference assemblies to import against.</param>
        public SyntaxValidatorProvider(IEnumerable<Assembly> importAssemblies = null)
            : base(importAssemblies)
        {
        }

        /// <summary>
        /// Gets the generic base type definition.
        /// </summary>
        protected override Type BaseType
        {
            get { return typeof(SyntaxValidator<>); }
        }
    }
}
