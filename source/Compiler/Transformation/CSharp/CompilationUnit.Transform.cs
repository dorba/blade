using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitCompilationUnit(CompilationUnitSyntax node)
        {
            var model = new CompilationModel();
            var declarations = node.Members.SelectMany(m => Visit(m)).ToArray();

            // set top level members
            foreach (var item in declarations.OfType<ClassDeclaration>())
                model.Classes.Add(item);

            yield return model;
        }
    }
}
