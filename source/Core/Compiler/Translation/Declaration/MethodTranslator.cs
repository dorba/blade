using System;
using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles the translation of method declarations.
    /// </summary>
    [Translator]
    internal class MethodTranslator : Translator<MethodDeclaration>
    {
        public override void Translate(MethodDeclaration model, TranslationContext context)
        {
            if (model == null)
                return;

            context.WriteDeclaration(model);
            context.Write(" = function (");

            if (model.HasParameters)
            {
                context.WriteModels(model.Parameters, ", ");
            }

            // begin method
            context.WriteLine(") {");
            context.Indent();

            // set optional params to defaults
            foreach (var param in model.Parameters.Where(p => p.Definition.HasDefaultValue))
            {
                context.Write(String.Format("{0} = ({0} !== undefined) ? {0} : ", param.Name));
                context.WriteModel(param.DefaultExpression);
                context.WriteLine(";");
            }

            // write method body
            context.WriteModelBody(model.Body);
            context.Unindent();
            context.EnsureLineBreak();
            context.WriteLine("}");
        }
    }
}