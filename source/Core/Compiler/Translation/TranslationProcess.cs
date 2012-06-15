using System;
using System.Linq;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// A translator for converting models in javascript.
    /// </summary>
    internal class TranslationProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the translation process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            if (context == null || context.Model == null)
                return;

            if (context.OutputStream == null || !context.OutputStream.CanWrite)
                throw new CompilationException("The translation output stream is null or not writable.");

            var translationCtx = new TranslationContext();
            translationCtx.OutputStream = context.OutputStream;

            // write enum declarations
            var enumTranslator = new EnumTranslator();
            foreach (var item in context.Model.Enums)
                enumTranslator.Translate(item, translationCtx);

            // write class declarations
            var classTranslator = new ClassTranslator();
            foreach (var item in ClassSorter.Sort(context.Model.Classes))
                classTranslator.Translate(item, translationCtx);

            // write global statements
            if (context.Model.GlobalStatements.Any())
            {
                translationCtx.WriteLine();
                foreach (var item in context.Model.GlobalStatements)
                    translationCtx.WriteModel(item);
            }
        }
    }
}
