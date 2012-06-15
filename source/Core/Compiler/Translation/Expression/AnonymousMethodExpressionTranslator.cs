using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an anonymous method.
    /// </summary>
    [Translator]
    internal class AnonymousMethodExpressionTranslator : Translator<AnonymousMethodExpression>
    {
        public override void Translate(AnonymousMethodExpression model, TranslationContext context)
        {
            // write function declaration
            context.Write("function(");
            context.WriteModels(model.Parameters, ", ");
            context.WriteLine(") {");
            context.Indent();

            // force no braces on body
            model.Body.HasBraces = false;
            context.WriteModel(model.Body);
            context.EnsureLineBreak();
            context.Unindent();
            context.Write("}");
        }
    }
}
