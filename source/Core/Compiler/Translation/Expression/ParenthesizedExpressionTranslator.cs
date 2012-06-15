using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a parenthesized expression.
    /// </summary>
    [Translator]
    internal class ParenthesizedExpressionTranslator : Translator<ParenthesizedExpression>
    {
        public override void Translate(ParenthesizedExpression model, TranslationContext context)
        {
            context.Write("(");
            context.WriteModel(model.Expression);
            context.Write(")");
        }
    }
}
