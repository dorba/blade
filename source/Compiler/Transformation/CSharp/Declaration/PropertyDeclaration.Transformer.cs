using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            var model = CreateSymbolic<PropertyDeclaration, PropertyDefinition>(node);

            foreach (var acc in node.AccessorList.Accessors)
            {
                if (acc.Kind == SyntaxKind.GetAccessorDeclaration)
                    model.GetAccessor = TransformToSingleOrNull<CodeBlock>(acc);
                else if (acc.Kind == SyntaxKind.SetAccessorDeclaration)
                    model.SetAccessor = TransformToSingleOrNull<CodeBlock>(acc);
            }

            yield return model;
        }
    }
}
