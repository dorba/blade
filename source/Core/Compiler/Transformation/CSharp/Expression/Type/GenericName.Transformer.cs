using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitGenericName(GenericNameSyntax node)
        {
            // generic names are simply tread like regular identifiers for now
            yield return CreateSymbolic<IdentifierName, IDefinition>(node, node.Identifier.ValueText);
        }
    }
}
