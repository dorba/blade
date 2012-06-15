using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of throw statement models.
    /// </summary>
    [Translator]
    internal class ThrowStatementTranslator : Translator<ThrowStatement>
    {
        public override void Translate(ThrowStatement model, TranslationContext context)
        {
            context.EnsureLineBreak();
            context.Write("throw ");
            context.WriteModel(model.Expression);
            context.WriteLine(";");
        }
    }
}
