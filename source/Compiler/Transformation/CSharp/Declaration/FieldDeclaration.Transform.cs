using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            foreach (var declNode in node.Declaration.Variables)
            {
                var model = CreateSymbolic<FieldDeclaration, FieldDefinition>(declNode);
                model.Initializer = TransformToSingleOrNull<ExpressionModel>(declNode.Initializer);

                yield return model;
            }
        }
    }
}
