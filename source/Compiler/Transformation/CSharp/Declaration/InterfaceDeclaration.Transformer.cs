using System;
using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            // interfaces are not part of the compilation model.
            return Enumerable.Empty<IModel>();
        }
    }
}
