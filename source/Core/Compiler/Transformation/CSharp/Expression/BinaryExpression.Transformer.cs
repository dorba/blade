using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            BinaryExpressionBase model = null;

            switch (node.Kind)
            {
                case SyntaxKind.AddAssignExpression:
                case SyntaxKind.AndAssignExpression:
                case SyntaxKind.AssignExpression:
                case SyntaxKind.DivideAssignExpression:
                case SyntaxKind.ExclusiveOrAssignExpression:
                case SyntaxKind.LeftShiftAssignExpression:
                case SyntaxKind.ModuloAssignExpression:
                case SyntaxKind.MultiplyAssignExpression:
                case SyntaxKind.OrAssignExpression:
                case SyntaxKind.RightShiftAssignExpression:
                case SyntaxKind.SubtractAssignExpression:
                    var assignment = Create<AssignmentExpression>(node);
                    var lastLeftNode = node.Left.DescendantNodesAndSelf().OfType<IdentifierNameSyntax>().Last();
                    assignment.Assignee = TransformToSingle<IdentifierName>(lastLeftNode);
                    model = assignment;
                    break;

                case SyntaxKind.AsExpression:
                    model = Create<AsTypeExpression>(node);
                    break;

                case SyntaxKind.IsExpression:
                    model = Create<IsTypeExpression>(node);
                    break;

                default:
                    model = Create<BinaryExpression>(node);
                    break;
            }

            model.LeftExpression = TransformToSingle<ExpressionModel>(node.Left);
            model.RightExpression = TransformToSingle<ExpressionModel>(node.Right);
            model.Operator = node.OperatorToken.ValueText;

            yield return model;
        }
    }
}
