using System;
using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Extensibility
{
    /// <summary>
    /// Provides the ability to create transform extension instances from symbols.
    /// </summary>
    internal class ExtensionFactory
    {
        private const string _extClassName = "System.ExtensionAttribute";

        /// <summary>
        /// Creates transform instances.
        /// </summary>
        /// <param name="symbol">The symbol to create from.</param>
        /// <returns>A collection of extensions.</returns>
        public IEnumerable<IExtension> GetExtensions(ISymbol symbol)
        {
            if (symbol == null)
                yield break;

            var attributes = symbol.GetAttributes();
            if (attributes == null)
                yield break;

            foreach (var attr in attributes)
            {
                // look for extension attribute
                var extAttr = attr.AttributeClass.GetAttributes()
                    .AsEnumerable().SingleOrDefault(aa =>
                        aa.AttributeClass.GetFullName() == _extClassName);

                if (extAttr == null)
                    continue;

                // handler class assembly and type names come from arguments of extension attribute
                var asmName = extAttr.ConstructorArguments.ElementAt(0).Value.ToString();
                var typeName = extAttr.ConstructorArguments.ElementAt(1).Value.ToString();

                // applied attribute arguments are passed directly to handler ctor
                var args = attr.ConstructorArguments.AsEnumerable().Select(p => p.Value);

                // create an instance of the handler class
                var instanceWrapper = Activator.CreateInstance(asmName, typeName, false, 0, null, args.ToArray(), null, null);
                var inst = instanceWrapper.Unwrap() as IExtension;

                if (inst == null)
                    throw new InvalidOperationException("Unable to create transform extension for: " + attr.AttributeClass.GetFullName());

                // support for named arguments (these bind to properties on the handler)
                foreach (var prop in attr.NamedArguments.AsEnumerable())
                    inst.GetType().GetProperty(prop.Key).SetValue(inst, prop.Value.Value, null);

                yield return inst;
            }
        }
    }
}
