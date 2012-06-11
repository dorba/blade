using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a default type expression.
    /// </summary>
    [Translator]
    internal class DefaultTypeExpressionTranslator : Translator<DefaultExpression>
    {
        public override void Translate(DefaultExpression model, TranslationContext context)
        {
            // getting the default type of literal expression is possible,
            // however for generic type params it will require a
            // more robust type system on the client.
            throw new CompilationException("Default type expressions are not supported.", model);

            //var symbolicModel = model.Target as ISymbolicModel;
            //if (symbolicModel != null)
            //    context.Write(Utilities.GetDefaultValue(symbolicModel.OriginatingSymbol as TypeSymbol));
            //else context.Write("null");
        }
    }
}
