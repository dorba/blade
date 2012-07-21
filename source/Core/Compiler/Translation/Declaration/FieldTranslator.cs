using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles the translation of field declarations.
    /// </summary>
    [Translator]
    internal class FieldTranslator : Translator<FieldDeclaration>
    {
        public override void Translate(FieldDeclaration model, TranslationContext context)
        {
            if (model == null)
                return;

            context.WriteDeclaration(model);
            context.Write(" = ");

            if (model.Initializer == null)
            {
                context.Write(context.GetDefaultValue(model.Definition.Type));
            }
            else
            {
                // write the initializer
                context.InitializingType = model.Container;
                context.WriteModel(model.Initializer);
                context.InitializingType = null;
            }

            context.WriteLine(";");
        }
    }
}