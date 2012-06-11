using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitConditionalExpression(ConditionalExpressionSyntax node)
        {
            var model = Create<ConditionalExpression>(node);
            model.Condition = TransformToSingle<ExpressionModel>(node.Condition);
            model.TrueExpression = TransformToSingle<ExpressionModel>(node.WhenTrue);
            model.FalseExpression = TransformToSingle<ExpressionModel>(node.WhenFalse);

            yield return model;
        }
    }
}
