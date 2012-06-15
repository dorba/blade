using System;
using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of for-loop statement models.
    /// </summary>
    [Translator]
    internal class ForStatementTranslator : Translator<ForStatement>
    {
        public override void Translate(ForStatement model, TranslationContext context)
        {
            if (model.Initializers.Any())
                throw new CompilationException("Initializers are not implemented.", model);

            context.EnsureLineBreak();
            context.Write("for(");

            if (model.VariableDeclaration != null && model.VariableDeclaration.Variables.Any())
            {
                context.Write("var ");
                context.WriteModels(model.VariableDeclaration.Variables, ", ");
            }

            // write condition
            context.Write("; ");
            context.WriteModel(model.Condition);

            // write incrementors
            context.Write("; ");
            context.WriteModels(model.Incrementors, ", ");

            // write body
            context.WriteLine(") {");
            context.Indent();

            context.WriteModelBody(model.Statement);

            context.Unindent();
            context.WriteLine("}");
        }
    }
}
