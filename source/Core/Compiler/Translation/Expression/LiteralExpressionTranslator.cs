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
                    // write as quoted string
                    context.Write("'" + model.Text.Replace("'", "\\'") + "'");
                }
                else context.Write(model.Text);
            }
        }
    }
}
