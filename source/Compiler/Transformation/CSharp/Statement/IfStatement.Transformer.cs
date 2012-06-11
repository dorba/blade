using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitIfStatement(IfStatementSyntax node)
        {
            var model = Create<IfStatement>(node);
            model.Condition = TransformToSingle<ExpressionModel>(node.Condition);
            model.Statement = TransformToSingle<StatementModel>(node.Statement);
            model.ElseStatement = TransformToSingleOrNull<StatementModel>(node.Else);

            yield return model;
        }

        public override IEnumerable<IModel> VisitElseClause(ElseClauseSyntax node)
        {
            yield return Visit(node.Statement).Single();
        }
    }
}
