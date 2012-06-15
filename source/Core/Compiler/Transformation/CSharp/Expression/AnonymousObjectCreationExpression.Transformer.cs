using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
        {
            var model = Create<AnonymousObjectExpression>(node);

            foreach (var item in node.Initializers)
            {
                var assignment = Create<AssignmentExpression>(item);
                assignment.RightExpression = TransformToSingle<ExpressionModel>(item.Expression);
                assignment.LeftExpression = assignment.Assignee =
                    TransformToSingle<IdentifierName>(item.NameEquals.Identifier);

                model.Assignments.Add(assignment);
            }

            yield return model;
        }
    }
}
