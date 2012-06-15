using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitCastExpression(CastExpressionSyntax node)
        {
            var model = Create<CastExpression>(node);
            model.Expression = TransformToSingle<ExpressionModel>(node.Expression);

            yield return model;
        }
    }
}
