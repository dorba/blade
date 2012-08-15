using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            var model = Create<LambdaExpression>(node);
            model.Body = TransformToSingle<ExpressionModel>(node.Body);
            model.Parameters.Add(TransformToSingle<ParameterDeclaration>(node.Parameter));

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
