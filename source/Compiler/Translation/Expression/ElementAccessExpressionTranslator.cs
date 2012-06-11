using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an element access expressions.
    /// </summary>
    [Translator]
    internal class ElementAccessExpressionTranslator : Translator<ElementAccessExpression>
    {
        public override void Translate(ElementAccessExpression model, TranslationContext context)
        {
            context.WriteModel(model.Expression);
            context.Write("[");
            context.WriteModels(model.Arguments.Select(a => a.Expression), ", ");
            context.Write("]");
        }
    }
}
