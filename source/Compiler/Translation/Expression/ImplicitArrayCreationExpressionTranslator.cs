using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an implicitly typed array creation expression.
    /// </summary>
    [Translator]
    internal class ImplicitArrayCreationExpressionTranslator : Translator<ImplicitArrayCreationExpression>
    {
        public override void Translate(ImplicitArrayCreationExpression model, TranslationContext context)
        {
            // implicit array creation should always have an initializer
            if (model.Initializer == null)
            {
                throw new CompilationException("Compiler error: Implicit array creation expected an intializer.", model);
            }

            // write as initialized array.
            context.Write("[");
            context.WriteModels(model.Initializer.Expressions, ", ");
            context.Write("]");
        }
    }
}
