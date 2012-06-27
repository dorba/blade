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
            if (HandleSpecialCases(model, context))
                return;

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

        private bool HandleSpecialCases(NewExpression model, TranslationContext context)
        {
            // check for special cases
            if (model.Type != null)
            {
                if (model.Type.TypeKind == TypeDefinitionKind.Delegate)
                {
                    // delegates should have a single argument
                    context.WriteModel(model.Arguments[0].Expression);
                    return true;
                }

                if (model.Type.TypeKind == TypeDefinitionKind.Anonymous)
                {
                    // types view as anonymous, instanciate using object literal notation
                    if (model.Initializer == null || !model.Initializer.Expressions.Any())
                        context.Write("{}");
                    else
                    {
                        context.WriteLine("{");
                        context.Indent();

                        for (int i = 0; i < model.Initializer.Expressions.Count; i++)
                        {
                            var assignment = model.Initializer.Expressions[i] as AssignmentExpression;
                            if (assignment == null)
                                throw new CompilationException("All initializer expressions must be assignments.", model);

                            context.Write(assignment.Assignee.Definition.Name + ": ");
                            context.WriteModel(assignment.RightExpression);

                            if ((i + 1) < model.Initializer.Expressions.Count)
                                context.WriteLine(",");
                        }

                        context.WriteLine();
                        context.Unindent();
                        context.Write("}");
                    }

                    return true;
                }
            }

            return false;
        }
    }
}
