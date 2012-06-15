using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitArrayType(ArrayTypeSyntax node)
        {
            var model = Create<ArrayTypeExpression>(node);
            model.ElementType = GetDefinition<ITypeDefinition>(node.ElementType);
            TransformInto<ArrayRankSpecifier>(node.RankSpecifiers, model.RankExpressions);

            yield return model;
        }
    }
}
