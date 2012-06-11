using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of foreach loop statement models.
    /// </summary>
    [Translator]
    internal class ForEachStatementTranslator : Translator<ForEachStatement>
    {
        public override void Translate(ForEachStatement model, TranslationContext context)
        {
            context.EnsureLineBreak();

            var identifier = model.IdentifierName;
            var enumerator = "$" + identifier + "_enum";

            context.WriteLine("var " + identifier + " = null;");
            context.Write("var " + enumerator + " = ");
            context.WriteModel(model.Expression);
            context.WriteLine(".GetEnumerator();");

            context.WriteLine("while(" + enumerator + ".MoveNext()) {");
            context.Indent();
            
            context.WriteLine(identifier + " = " + enumerator + ".get_Current();");
            context.WriteModelBody(model.Statement);
            context.EnsureLineBreak();

            context.Unindent();
            context.WriteLine("}");
        }
    }
}
