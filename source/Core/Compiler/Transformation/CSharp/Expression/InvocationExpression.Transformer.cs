using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            var model = Create<InvocationExpression>(node);
            model.Expression = TransformToSingle<ExpressionModel>(node.Expression);
            TransformInto<Argument>(node.ArgumentList, model.Arguments);

            yield return model;
        }
    }
}
