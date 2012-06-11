using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitEventDeclaration(EventDeclarationSyntax node)
        {
            var model = CreateSymbolic<EventDeclaration, EventDefinition>(node);

            foreach (var acc in node.AccessorList.Accessors)
            {
                if (acc.Kind == SyntaxKind.AddAccessorDeclaration)
                    model.AddAccessor = TransformToSingleOrNull<CodeBlock>(acc);
                else if (acc.Kind == SyntaxKind.RemoveAccessorDeclaration)
                    model.RemoveAccessor = TransformToSingleOrNull<CodeBlock>(acc);
            }

            yield return model;
        }

        public override IEnumerable<IModel> VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
        {
            foreach (var variable in node.Declaration.Variables)
            {
                yield return CreateSymbolic<EventDeclaration, EventDefinition>(variable);
            }
        }
    }
}
