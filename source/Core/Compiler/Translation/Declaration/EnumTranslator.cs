using System;
using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles the translation of enum declarations.
    /// </summary>
    [Translator]
    internal class EnumTranslator : Translator<EnumDeclaration>
    {
        public override void Translate(EnumDeclaration model, TranslationContext context)
        {
            if (model == null)
                return;
        }
    }
}
