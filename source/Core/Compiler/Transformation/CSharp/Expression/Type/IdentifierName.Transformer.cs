using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitIdentifierName(IdentifierNameSyntax node)
        {
            var model = CreateSymbolic<IdentifierName, IDefinition>(node, node.Identifier.ValueText);

            // Ultimately the symbol should always be resolved
            // However, due to limitation of first Roslyn release,
            // Some nodes do not provide semantics.
            // TODO: try again after next Roslyn release!
            if (model.Definition == null || model.Definition.Symbol == null)
            {
                AddWarning("Unable to create definition for identifier: " + node.Identifier.ValueText +
                    " (this is likely due to a limitation of Roslyn CTP)", node);

                // manually set the definition for now
                model.Definition = new EmptyDefinition
                {
                    Kind = DefinitionKind.Local,
                    Name = node.Identifier.ValueText
                };

                yield return model;
                yield break;
            }

            yield return model;
        }
    }
}
