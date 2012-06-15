using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of switch statement models.
    /// </summary>
    [Translator]
    internal class SwitchStatementTranslator : Translator<SwitchStatement>
    {
        public override void Translate(SwitchStatement model, TranslationContext context)
        {
            // begin switch statement
            context.EnsureLineBreak();
            context.Write("switch (");
            context.WriteModel(model.Expression);
            context.WriteLine(") {");
            context.Indent();

            // write sections
            foreach (var section in model.Sections)
            {
                foreach (var label in section.Labels)
                {
                    // labels
                    context.EnsureLineBreak();
                    context.Write("case ");
                    context.WriteModel(label);
                    context.WriteLine(":");
                }

                if (section.IsDefault)
                    context.WriteLine("default:");

                // write statements
                context.Indent();
                context.WriteModels(section.Statements, "");
                context.Unindent();
            }

            // end statement
            context.Unindent();
            context.WriteLine("}");
        }
    }
}
