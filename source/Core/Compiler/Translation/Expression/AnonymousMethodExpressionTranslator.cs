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
            // write function declaration, with params
            context.Write("Blade.del(this, function(");
            context.WriteModels(model.Parameters, ", ");
            context.WriteLine(") {");

            // write inner body
            context.Indent();
            context.WriteModelBody(model.Body);
            context.Unindent();

            // close function declaration
            context.Write("})");
        }
    }
}
