using Blade.Compiler.Models;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Handles translation of a member access expression.
    /// </summary>
    [Translator]
    internal class MemberAccessExpressionTranslator : Translator<MemberAccessExpression>
    {
        public override void Translate(MemberAccessExpression model, TranslationContext context)
        {
            if (HandleEnumMember(model, context) ||
                HandleExtensionMethod(model, context))
                return;

            if (model.Expression != null)
            {
                var preLen = context.Length;
                context.WriteModel(model.Expression);

                // only write dot if left expression
                // produced some actual output 
                if (context.Length > preLen)
                    context.Write(".");
            }

            var explicitCall = context.UsingExplicitCall;
            if (model.Expression as BaseExpression != null)
                context.UsingExplicitCall = true;

            context.WriteModel(model.Member);
            context.UsingExplicitCall = explicitCall;
        }

        private bool HandleExtensionMethod(MemberAccessExpression model, TranslationContext context)
        {
            var symbol = model.Member.GetSymbolAs<IMethodSymbol>();
            if (symbol == null)
                return false;

            if (symbol.ReducedFrom == null)
                return false;

            // reduced extension methods are viewed as instance members
            // we must explicitly set these to be static
            model.Member.Definition.Modifiers.IsStatic = true;

            // write the method itself, and set extension method context
            context.WriteModel(model.Member);
            context.ExtensionMethodTarget = model.Expression;

            return true;
        }

        private bool HandleEnumMember(MemberAccessExpression model, TranslationContext context)
        {
            if (model.Member == null || model.Member.Definition == null)
                return false;

            var def = model.Member.Definition as IMemberDefinition;
            if (def == null)
                return false;

            if (def.MemberKind != MemberDefinitionKind.EnumMember)
                return false;

            var symbol = def.Symbol as Roslyn.Compilers.Common.IFieldSymbol;
            if (symbol == null)
                throw new CompilationException("Unable to resolve valid symbol for enum member:" + def.Name, model);

            if (!symbol.HasConstantValue)
                throw new CompilationException("Unable to determine constant value of enum member: " + def.Name, model);

            context.Write(symbol.ConstantValue.ToString());

            return true;
        }
    }
}
