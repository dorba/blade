using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
        {
            var model = Create<ArrayRankSpecifier>(node);
            TransformInto<ExpressionModel>(node.Sizes, model.Sizes);
            model.Rank = node.Rank;

            yield return model;
        }
    }
}
