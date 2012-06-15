using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an object cast.
    /// </summary>
    [Translator]
    internal class CastExpressionTranslator : Translator<CastExpression>
    {
        public override void Translate(CastExpression model, TranslationContext context)
        {
            // currently there is no special behavior
            // applied when explicitly casting types.

            context.WriteModel(model.Expression);
        }
    }
}
