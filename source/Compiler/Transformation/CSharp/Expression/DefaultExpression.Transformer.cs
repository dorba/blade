using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitDefaultExpression(DefaultExpressionSyntax node)
        {
            var model = Create<DefaultExpression>(node);
            model.Type = GetDefinition<ITypeDefinition>(node.Type);

            yield return model;
        }
    }
}
