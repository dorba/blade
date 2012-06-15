using System;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of try statement models.
    /// </summary>
    [Translator]
    internal class TryStatementTranslator : Translator<TryStatement>
    {
        public override void Translate(TryStatement model, TranslationContext context)
        {
            // begin try
            context.EnsureLineBreak();
            context.WriteLine("try {");
            context.Indent();

            // write try body
            context.WriteModelBody(model.Body);

            // end try
            context.Unindent();
            context.EnsureLineBreak();
            context.Write("}");

            // write catches
            if (model.HasCatch)
            {
                foreach (var item in model.Catches)
                {
                    context.Write(" catch(");

                    // javascript catch requires an identifier, always
                    var identifier = (item.Identifier != null && !String.IsNullOrEmpty(item.Identifier.Name)) ? item.Identifier.Name : "ex$";
                    var typeName = (item.Type != null && !String.IsNullOrEmpty(item.Type.GetFullName())) ? item.Type.GetFullName() : null;

                    context.Write(identifier);

                    if (typeName != null && typeName != "Error")
                        context.Write(" if " + identifier + " instanceof " + typeName);

                    // begin catch
                    context.WriteLine(") {");
                    context.Indent();

                    // write catch body
                    context.WriteModelBody(item.Body);

                    // end catch
                    context.Unindent();
                    context.EnsureLineBreak();
                    context.Write("}");
                }
            }

            if (model.HasFinally)
            {
                // begin finally
                context.WriteLine(" finally {");
                context.Indent();

                // write finally body
                context.WriteModelBody(model.FinallyBody);

                // end finally
                context.Unindent();
                context.EnsureLineBreak();
                context.Write("}");
            }

            context.WriteLine();
        }
    }
}
