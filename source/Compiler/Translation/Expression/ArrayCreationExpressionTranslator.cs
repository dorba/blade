using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an array creation expression.
    /// </summary>
    [Translator]
    internal class ArrayCreationExpressionTranslator : Translator<ArrayCreationExpression>
    {
        public override void Translate(ArrayCreationExpression model, TranslationContext context)
        {
            if (model.TypeExpression.RankExpressions.Count > 1)
                throw new CompilationException("Multidimensional arrays are not supported.", model);

            if (model.Initializer != null)
            {
                // write as initialized array.
                context.Write("[");
                context.WriteModels(model.Initializer.Expressions, ", ");
                context.Write("]");
            }
            else
            {
                // write an new empty array (repecting default values)
                if (model.TypeExpression.RankExpressions.Count == 1)
                {
                    var rankExp = model.TypeExpression.RankExpressions[0];
                    if (rankExp.Rank > 1)
                        throw new CompilationException("Multidimensional arrays are not supported.", model);

                    if (rankExp.Sizes.Any())
                    {
                        context.Write("new Array(");
                        context.WriteModel(rankExp.Sizes[0]);
                        context.Write(")");
                    }
                    else context.Write("[]");
                }
                else context.Write("[]");
            }
        }
    }
}
