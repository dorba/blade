using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            var model = CreateSymbolic<EnumDeclaration, EnumDefinition>(node, node.Identifier.ValueText);
            TransformInto<EnumMemberDeclaration>(node.Members, model.Members);

            yield return model;
        }

        public override IEnumerable<IModel> VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            var model = CreateSymbolic<EnumMemberDeclaration, EnumMemberDefinition>(node, node.Identifier.ValueText);

            if (node.EqualsValue != null)
                model.Value = Visit(node.EqualsValue.Value).Single() as ExpressionModel;

            yield return model;
        }
    }
}
