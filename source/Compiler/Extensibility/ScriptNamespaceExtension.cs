using System.Collections.Generic;
using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    internal sealed class ScriptNamespaceExtension : Extension
    {
        private string _name;

        public ScriptNamespaceExtension(string name)
        {
            _name = name;
        }

        public override void ExtendDefinition(IDefinition definition)
        {
            // only applies to type definitions
            var typeDef = definition as ITypeDefinition;
            if (typeDef != null)
                typeDef.Namespace = _name;
        }
    }
}
