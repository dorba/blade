using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of this keyword, when used for member access.
    /// </summary>
    [Translator]
    internal class ThisExpressionTranslator : Translator<ThisExpression>
    {
        public override void Translate(ThisExpression model, TranslationContext context)
        {
            context.Write("this");
        }
    }
}
