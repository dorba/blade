using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an if statement.
    /// </summary>
    [Translator]
    internal class IfStatementTranslator : Translator<IfStatement>
    {
        public override void Translate(IfStatement model, TranslationContext context)
        {
            WriteIfModel(model, context, false);
        }

        private void WriteIfModel(IfStatement model, TranslationContext context, bool nested)
        {
            // if beginning of new statement, ensure line break
            if (!nested)
                context.EnsureLineBreak();

            // opening if clause
            context.Write("if (");
            context.WriteModel(model.Condition);
            context.WriteLine(") {");

            // write statement
            context.Indent();
            context.WriteModelBody(model.Statement);
            context.Unindent();
            context.Write("}");

            // write else condition, or newline
            if (model.HasElseStatement)
            {
                context.Write(" else ");

                // handle if-else explicitly
                var elseIf = model.ElseStatement as IfStatement;
                if (elseIf != null)
                    WriteIfModel(elseIf, context, true);
                else
                {
                    // begin final else statement
                    context.WriteLine("{");
                    context.Indent();

                    // end final else statement
                    context.WriteModelBody(model.ElseStatement);
                    context.Unindent();
                    context.WriteLine("}");
                }
            }
            else context.WriteLine();
        }
    }
}
