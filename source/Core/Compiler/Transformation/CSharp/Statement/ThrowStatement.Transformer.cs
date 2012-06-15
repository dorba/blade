using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitThrowStatement(ThrowStatementSyntax node)
        {
            var model = Create<ThrowStatement>(node);
            model.Expression = TransformToSingleOrNull<ExpressionModel>(node.Expression);

            yield return model;
        }
    }
}
