using System.Web;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a literal expression.
    /// </summary>
    [Translator]
    internal class LiteralExpressionTranslator : Translator<LiteralExpression>
    {
        public override void Translate(LiteralExpression model, TranslationContext context)
        {
            if (model.Text != null)
            {
                if (model.Type == LiteralType.Character || model.Type == LiteralType.String)
                {
                    context.Write("'" + HttpUtility.JavaScriptStringEncode(model.Text) + "'");
                }
                else context.Write(model.Text);
            }
        }
    }
}
