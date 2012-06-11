using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitForEachStatement(ForEachStatementSyntax node)
        {
            var model = Create<ForEachStatement>(node);
            model.Expression = TransformToSingle<ExpressionModel>(node.Expression);
            model.Statement = TransformToSingle<StatementModel>(node.Statement);
            model.IdentifierName = node.Identifier.ValueText;

            yield return model;
        }
    }
}
