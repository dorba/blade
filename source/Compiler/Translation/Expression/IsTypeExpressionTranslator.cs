using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of type check with is keyword.
    /// </summary>
    [Translator]
    internal class IsTypeExpressionTranslator : Translator<IsTypeExpression>
    {
        public override void Translate(IsTypeExpression model, TranslationContext context)
        {
            context.Write("Blade.is(");
            context.WriteModel(model.LeftExpression);
            context.Write(", ");
            context.WriteModel(model.RightExpression);
            context.Write(")");
        }
    }
}
