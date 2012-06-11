using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of postfix unary expressions.
    /// </summary>
    [Translator]
    internal class PostfixUnaryExpressionTranslator : Translator<PostfixUnaryExpression>
    {
        public override void Translate(PostfixUnaryExpression model, TranslationContext context)
        {
            context.WriteModel(model.Operand);
            context.Write(model.Operator);
        }
    }
}
