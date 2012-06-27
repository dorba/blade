using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    internal sealed class ScriptNameExtension : Extension
    {
        private string _name;

        public ScriptNameExtension(string name)
        {
            _name = name;
        }

        public override void ExtendDefinition(IDefinition definition)
        {
            definition.Name = _name;
        }
    }
}
