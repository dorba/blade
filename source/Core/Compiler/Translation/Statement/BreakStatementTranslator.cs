using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of break statement models.
    /// </summary>
    [Translator]
    internal class BreakStatementTranslator : Translator<BreakStatement>
    {
        public override void Translate(BreakStatement model, TranslationContext context)
        {
            context.EnsureLineBreak();
            context.WriteLine("break;");
        }
    }
}
