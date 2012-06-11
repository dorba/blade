using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            var model = Create<VariableDeclarator>(node);
            model.Definition = GetDefinition<LocalDefinition>(node);
            model.EqualsValueExpression = TransformToSingleOrNull<ExpressionModel>(node.Initializer);

            yield return model;
        }
    }
}
