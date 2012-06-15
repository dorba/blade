using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitBlock(BlockSyntax node)
        {
            var block = Create<CodeBlock>(node);
            TransformInto<StatementModel>(node.Statements, block.Statements);
            block.HasBraces = (node.OpenBraceToken.Kind == SyntaxKind.OpenBraceToken);

            yield return block;
        }
    }
}
