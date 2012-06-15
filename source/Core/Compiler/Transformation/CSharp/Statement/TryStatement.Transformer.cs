using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitTryStatement(TryStatementSyntax node)
        {
            var model = Create<TryStatement>(node);
            model.Body = TransformToSingle<CodeBlock>(node.Block);
            model.FinallyBody = TransformToSingleOrNull<CodeBlock>(node.Finally);
            TransformInto<CatchStatement>(node.Catches, model.Catches);

            yield return model;
        }

        public override IEnumerable<IModel> VisitCatchClause(CatchClauseSyntax node)
        {
            var model = Create<CatchStatement>(node);
            model.Body = TransformToSingle<CodeBlock>(node.Block);

            if (node.Declaration != null)
            {
                if (node.Declaration.Identifier != null && node.Declaration.Identifier.Kind != SyntaxKind.None)
                    model.Identifier = GetDefinition<IDefinition>(node.Declaration, node.Declaration.Identifier.ValueText);

                model.Type = GetDefinition<ITypeDefinition>(node.Declaration.Type);
            }

            yield return model;
        }

        public override IEnumerable<IModel> VisitFinallyClause(FinallyClauseSyntax node)
        {
            yield return TransformToSingle<CodeBlock>(node.Block);
        }
    }
}
