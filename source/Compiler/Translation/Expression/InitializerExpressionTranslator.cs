using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an initializer expression.
    /// </summary>
    [Translator]
    internal class InitializerExpressionTranslator : Translator<InitializerExpression>
    {
        public override void Translate(InitializerExpression model, TranslationContext context)
        {
            context.Write("[");
            context.WriteModels(model.Expressions, ", ");
            context.Write("]");
        }
    }
}
