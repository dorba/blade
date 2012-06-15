using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a variable declarator model.
    /// </summary>
    [Translator]
    internal class VariableDeclaratorTranslator : Translator<VariableDeclarator>
    {
        public override void Translate(VariableDeclarator model, TranslationContext context)
        {
            context.Write(model.Definition.Name);

            if (model.EqualsValueExpression != null)
            {
                context.Write(" = ");
                context.WriteModel(model.EqualsValueExpression);
            }
        }
    }
}
