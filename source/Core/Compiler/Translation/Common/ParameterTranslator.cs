using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a parameter.
    /// </summary>
    [Translator]
    internal class ParameterTranslator : Translator<ParameterDeclaration>
    {
        public override void Translate(ParameterDeclaration model, TranslationContext context)
        {
            context.Write(model.Definition.Name);
        }
    }
}
