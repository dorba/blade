using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an object cast using the as keyword.
    /// </summary>
    [Translator]
    internal class AsTypeExpressionTranslator : Translator<AsTypeExpression>
    {
        public override void Translate(AsTypeExpression model, TranslationContext context)
        {
            context.Write("Blade.as(");
            context.WriteModel(model.LeftExpression);
            context.Write(", ");
            context.WriteModel(model.RightExpression);
            context.Write(")");
        }
    }
}
