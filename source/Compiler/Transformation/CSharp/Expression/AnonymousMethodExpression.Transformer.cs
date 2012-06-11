using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            var model = Create<AnonymousMethodExpression>(node);
            TransformInto<ParameterDeclaration>(node.ParameterList, model.Parameters);
            model.Body = TransformToSingleOrNull<CodeBlock>(node.Block);

            yield return model;
        }
    }
}
