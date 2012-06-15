using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        {
            var model = Create<LocalDeclarationStatement>(node);
            model.VariableDeclaration = TransformToSingle<VariableDeclaration>(node.Declaration);

            yield return model;
        }
    }
}
