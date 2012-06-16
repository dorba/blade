using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a binary expression.
    /// </summary>
    [Translator]
    internal class BinaryExpressionTranslator : Translator<BinaryExpression>
    {
        public override void Translate(BinaryExpression model, TranslationContext context)
        {
            context.WriteModel(model.LeftExpression);
            context.Write(" " + ToJsOperator(model) + " ");
            context.WriteModel(model.RightExpression);
        }

        private static string ToJsOperator(BinaryExpression model)
        {
            switch (model.Operator)
            {
                case "??": return "||";
                case "==": return "===";
                case "!=": return "!==";

                default: return model.Operator;
            }
        }
    }
}
