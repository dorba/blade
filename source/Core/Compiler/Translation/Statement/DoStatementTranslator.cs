using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of do-while statement models.
    /// </summary>
    [Translator]
    internal class DoStatementTranslator : Translator<DoStatement>
    {
        public override void Translate(DoStatement model, TranslationContext context)
        {
            // begin do statement
            context.EnsureLineBreak();
            context.WriteLine("do {");
            context.Indent();

            // write inner statement
            context.WriteModelBody(model.Statement);

            // end do statement
            // write while condition
            context.Unindent();
            context.Write("} while (");
            context.WriteModel(model.Condition);
            context.WriteLine(");");
        }
    }
}
