using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of return statement models.
    /// </summary>
    [Translator]
    internal class ReturnStatementTranslator : Translator<ReturnStatement>
    {
        public override void Translate(ReturnStatement model, TranslationContext context)
        {
            context.EnsureLineBreak();

            if (model.Expression == null)
            {
                context.WriteLine("return;");
            }
            else
            {
                context.Write("return ");
                context.WriteModel(model.Expression);
                context.WriteLine(";");
            }
        }
    }
}
