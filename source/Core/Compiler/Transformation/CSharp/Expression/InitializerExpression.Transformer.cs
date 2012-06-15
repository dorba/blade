using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitInitializerExpression(InitializerExpressionSyntax node)
        {
            var model = Create<InitializerExpression>(node);
            TransformInto<ExpressionModel>(node.Expressions, model.Expressions);

            yield return model;
        }
    }
}
