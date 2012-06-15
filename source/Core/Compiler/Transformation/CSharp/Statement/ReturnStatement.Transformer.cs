using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitReturnStatement(ReturnStatementSyntax node)
        {
            var model = Create<ReturnStatement>(node);
            model.Expression = TransformToSingleOrNull<ExpressionModel>(node.Expression);

            yield return model;
        }
    }
}
