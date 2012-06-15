using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of prefix unary expressions.
    /// </summary>
    [Translator]
    internal class PrefixUnaryExpressionTranslator : Translator<PrefixUnaryExpression>
    {
        public override void Translate(PrefixUnaryExpression model, TranslationContext context)
        {
            context.Write(model.Operator);
            context.WriteModel(model.Operand);
        }
    }
}
