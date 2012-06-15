using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of qualified name models.
    /// </summary>
    [Translator]
    internal class QualifiedNameTranslator : Translator<QualifiedName>
    {
        public override void Translate(QualifiedName model, TranslationContext context)
        {
            context.WriteModel(model.LeftName);
            context.Write(".");
            context.WriteModel(model.RightName);
        }
    }
}
