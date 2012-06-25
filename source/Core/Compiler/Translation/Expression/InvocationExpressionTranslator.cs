using System;
using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of an invocation expression.
    /// </summary>
    [Translator]
    internal class InvocationExpressionTranslator : Translator<InvocationExpression>
    {
        public override void Translate(InvocationExpression model, TranslationContext context)
        {
            context.WriteModel(model.Expression);
            var args = GetArguments(model);

            // when invoking explicitly, use 'call' and 
            // explicity pass the 'this' context in
            if (context.UsingExplicitCall)
            {
                var hasArgs = args.Any() || context.ExtensionMethodTarget != null;
                context.Write(".call(this" + (hasArgs ? ", " : ""));
            }
            else context.Write("(");

            // handle extension methods
            if (context.ExtensionMethodTarget != null)
            {
                // capture and set target to null, otherwise another
                // invocation expression will result in an infinite loop
                var target = context.ExtensionMethodTarget;
                context.ExtensionMethodTarget = null;

                context.WriteModel(target);
                if (args.Any())
                    context.Write(", ");
            }

            context.WriteModels(args, ", ");
            context.Write(")");
        }

        // gets ordered params, taking into account named arguments and optional parameters
        private IEnumerable<ExpressionModel> GetArguments(InvocationExpression model)
        {
            ISymbolicModel symbolicModel = null;

            var mbrAccess = model.Expression as MemberAccessExpression;
            if (mbrAccess != null)
                symbolicModel = mbrAccess.Member;
            else symbolicModel = model.Expression as ISymbolicModel;

            if (symbolicModel != null)
            {
                var methodDef = symbolicModel.Definition as MethodDefinition;

                // if not a method (e.g, lambda expression) no need to evaluate named/optional args
                if (methodDef == null) return model.Arguments.Select(a => a.Expression);

                var parameters = methodDef.Parameters;

                // if no arguments are named or optional, return
                if (!model.Arguments.Any(a => a.HasExplicitTarget) && !parameters.Any(p => p.HasDefaultValue))
                    return model.Arguments.Select(a => a.Expression);

                var undefinedLiteral = new LiteralExpression { Type = LiteralType.None, Text = "undefined" };
                var returnArgs = new List<ExpressionModel>(Enumerable.Repeat<LiteralExpression>(undefinedLiteral, parameters.Count));

                for (int i = 0; i < model.Arguments.Count; i++)
                {
                    var arg = model.Arguments[i];

                    if (arg.HasExplicitTarget)
                    {
                        var index = parameters.IndexOf(parameters.Single(p => p.Name == arg.ParameterName));
                        returnArgs[index] = arg.Expression;
                    }
                    else
                    {
                        // positional argument
                        returnArgs[i] = arg.Expression;
                    }
                }

                // no need for undefined at end of invocation
                // this is default behavior in javascript
                var last = returnArgs.LastOrDefault();
                while (last != null && last == undefinedLiteral)
                {
                    returnArgs.RemoveAt(returnArgs.Count - 1);
                    last = returnArgs.LastOrDefault();
                }

                return returnArgs;
            }

            return Enumerable.Empty<ExpressionModel>();
        }
    }
}
