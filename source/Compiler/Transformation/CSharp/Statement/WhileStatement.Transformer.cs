using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitWhileStatement(WhileStatementSyntax node)
        {
            var model = Create<WhileStatement>(node);
            model.Condition = TransformToSingle<ExpressionModel>(node.Condition);
            model.Statement = TransformToSingle<StatementModel>(node.Statement);

            yield return model;
        }

    }
}
