using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of while statement models.
    /// </summary>
    [Translator]
    internal class WhileStatementTranslator : Translator<WhileStatement>
    {
        public override void Translate(WhileStatement model, TranslationContext context)
        {
            // begin while statement
            context.EnsureLineBreak();
            context.Write("while (");
            context.WriteModel(model.Condition);
            context.WriteLine(") {");
            context.Indent();

            // write inner statement
            context.WriteModelBody(model.Statement);

            // end while statement
            context.Unindent();
            context.WriteLine("}");
        }
    }
}
