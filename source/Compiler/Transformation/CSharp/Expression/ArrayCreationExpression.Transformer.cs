using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
        {
            var model = Create<ArrayCreationExpression>(node);
            model.Initializer = TransformToSingleOrNull<InitializerExpression>(node.Initializer);
            model.TypeExpression = TransformToSingle<ArrayTypeExpression>(node.Type);

            yield return model;
        }

        public override IEnumerable<IModel> VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
        {
            // this is encountered when the size is implicit.
            // e.g, var x = new int[] { 1, 2, 3 }
            return Enumerable.Empty<IModel>();
        }
    }
}
