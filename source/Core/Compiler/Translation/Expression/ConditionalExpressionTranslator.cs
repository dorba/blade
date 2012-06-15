using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a conditional expression.
    /// </summary>
    [Translator]
    internal class ConditionalExpressionTranslator : Translator<ConditionalExpression>
    {
        public override void Translate(ConditionalExpression model, TranslationContext context)
        {
            context.WriteModel(model.Condition);
            context.Write(" ? ");
            context.WriteModel(model.TrueExpression);
            context.Write(" : ");
            context.WriteModel(model.FalseExpression);
        }
    }
}
