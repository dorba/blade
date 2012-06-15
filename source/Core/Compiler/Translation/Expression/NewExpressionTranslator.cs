using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an object creation expression.
    /// </summary>
    [Translator]
    internal class NewExpressionTranslator : Translator<NewExpression>
    {
        public override void Translate(NewExpression model, TranslationContext context)
        {
            // new syntax is ignored for delegate creation
            if (model.Type != null && model.Type.TypeKind == TypeDefinitionKind.Delegate)
            {
                // delegates should have a single argument
                context.WriteModel(model.Arguments[0].Expression);
                return;
            }

            var hasInit = model.Initializer != null &&
                model.Initializer.Expressions.Any();

            if (hasInit)
            {
                // wrap in function
                context.Write("(function() { var $new = ");
            }

            // always create types by full name
            context.Write("new " + model.Type.GetFullName() + "(");

            if (model.HasArguments)
                context.WriteModels(model.Arguments.Select(a => a.Expression), ", ");

            context.Write(")");

            if (hasInit)
            {
                // set assignments, and return result.
                context.Write(";");

                foreach (var item in model.Initializer.Expressions)
                {
                    context.Write("$new.");
                    context.WriteModel(item);
                    context.Write(";");
                }

                context.Write("return $new; })()");
            }
        }
    }
}
