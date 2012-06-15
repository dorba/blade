using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of any expression statement.
    /// </summary>
    [Translator]
    internal class ExpressionStatementTranslator : Translator<ExpressionStatement>
    {
        public override void Translate(ExpressionStatement model, TranslationContext context)
        {
            context.EnsureLineBreak();
            context.WriteModel(model.Expression);
            context.WriteLine(";");
        }
    }
}
