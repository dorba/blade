using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of block models.
    /// </summary>
    [Translator]
    internal class BlockTranslator : Translator<CodeBlock>
    {
        public override void Translate(CodeBlock model, TranslationContext context)
        {
            if (model.HasBraces)
            {
                context.WriteLine("{");
                context.Indent();
            }

            foreach (var item in model.Statements)
                context.WriteModel(item);

            if (model.HasBraces)
            {
                context.EnsureLineBreak();
                context.Unindent();
                context.Write("}");
            }
        }
    }
}
