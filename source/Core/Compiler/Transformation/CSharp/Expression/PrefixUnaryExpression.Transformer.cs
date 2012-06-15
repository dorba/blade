using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            var model = Create<PrefixUnaryExpression>(node);
            model.Operand = TransformToSingle<ExpressionModel>(node.Operand);
            model.Operator = node.OperatorToken.ValueText;

            yield return model;
        }
    }
}
