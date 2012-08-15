using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            var model = Create<LambdaExpression>(node);
            model.Body = TransformToSingle<ISyntacticModel>(node.Body);
            TransformInto<ParameterDeclaration>(node.ParameterList, model.Parameters);

            // if the lambda returns a value an the body is an expression,
            // we should explicitly include the return statement
            var expr = model.Body as ExpressionModel;
            if (expr != null)
            {
                var info = GetSymbol(node) as MethodSymbol;
                if (info != null && info.ReturnType.SpecialType != Roslyn.Compilers.SpecialType.System_Void)
                {
                    model.Body = new ReturnStatement { Expression = expr };
                }
            }

            yield return model;
        }
    }
}
