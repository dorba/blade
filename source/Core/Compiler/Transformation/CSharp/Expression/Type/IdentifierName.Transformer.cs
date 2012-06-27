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

            // if unable to resolve a symbol (this can be the case for anonymous or dynamic types)
            // then we work from the locally declared identifier name
            if (model.Definition == null || model.Definition.Symbol == null)
            {
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
