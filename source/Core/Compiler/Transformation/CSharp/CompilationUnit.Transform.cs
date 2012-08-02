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

            SetGlobalStatements(model);

            yield return model;
        }

        private static void SetGlobalStatements(CompilationModel model)
        {
            //// locate any static constructors
            //var staticCtors = model.Classes
            //    .SelectMany(c => c.Constructors)
            //    .Where(c => c.IsStatic);

            //// add global new expressions for each one
            //foreach (var ctor in staticCtors)
            //{
            //    model.GlobalStatements.Add(new ExpressionStatement
            //    {
            //        Expression = new NewExpression { Type = ctor.Definition.ContainingType }
            //    });
            //}
        }
    }
}
