using System;
using System.ComponentModel.Composition;
using System.Collections.Generic;
using Blade.Compiler.Models;
using System.Linq;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Provides some common routines for use internally during translation.
    /// </summary>
    internal static class TranslationHelper
    {
        /// <summary>
        /// Represents the javascript undefined value, as a literal expression.
        /// </summary>
        public static readonly LiteralExpression JsUndefined = new LiteralExpression
        {
            Type = LiteralType.None,
            Text = "undefined"
        };

        /// <summary>
        /// Resolves a set of expressions that represent the input arguments to an invocation.
        /// </summary>
        /// <param name="parameters">The method parameter definitions.</param>
        /// <param name="arguments">The argument list.</param>
        /// <returns>The resulting expression set.</returns>
        public static IEnumerable<ExpressionModel> GetInvocationArgs(IEnumerable<ParameterDefinition> parameters, IEnumerable<Argument> arguments)
        {
            if (parameters == null || !parameters.Any())
                return arguments != null ? arguments.Select(a => a.Expression) : Enumerable.Empty<ExpressionModel>();

            if (!arguments.Any(a => a.HasExplicitTarget) &&
                !parameters.Any(p => p.HasDefaultValue))
                return arguments != null ? arguments.Select(a => a.Expression) : Enumerable.Empty<ExpressionModel>();

            // begin with all args undefined
            var returnArgs = new List<ExpressionModel>(
                Enumerable.Repeat<LiteralExpression>(JsUndefined, parameters.Count()));


            for (int i = 0; i < arguments.Count(); i++)
            {
                var arg = arguments.ElementAt(i);

                if (arg.HasExplicitTarget)
                {
                    // locate the matching parameter
                    var index = -1;
                    while (index < parameters.Count() - 1)
                        if (parameters.ElementAt(++index).Name == arg.ParameterName) break;

                    // set the named target
                    returnArgs[index] = arg.Expression;
                }
                else
                {
                    // otherwise, it's a positional argument
                    returnArgs[i] = arg.Expression;
                }
            }

            // no need for undefined at end of invocation
            // this is default behavior of javascript
            var last = returnArgs.LastOrDefault();
            while (last != null && last == JsUndefined)
            {
                returnArgs.RemoveAt(returnArgs.Count - 1);
                last = returnArgs.LastOrDefault();
            }

            return returnArgs;
        }
    }
}
