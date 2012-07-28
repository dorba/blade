using System;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a local variable declaration.
    /// </summary>
    [Translator]
    internal class LocalDeclarationTranslator : Translator<LocalDeclarationStatement>
    {
        public override void Translate(LocalDeclarationStatement model, TranslationContext context)
        {
            context.EnsureLineBreak();

            context.Write("var ");
            context.WriteModels(model.VariableDeclaration.Variables, ", " + Environment.NewLine);

            context.WriteLine(";");
        }
    }
}
