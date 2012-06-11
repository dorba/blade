using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an explicit base call.
    /// </summary>
    [Translator]
    internal class BaseExpressionTranslator : Translator<BaseExpression>
    {
        public override void Translate(BaseExpression model, TranslationContext context)
        {
            context.Write("$base");
        }
    }
}
