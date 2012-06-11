using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
        {
            var model = Create<ImplicitArrayCreationExpression>(node);
            model.Initializer = TransformToSingle<InitializerExpression>(node.Initializer);

            yield return model;
        }
    }
}
