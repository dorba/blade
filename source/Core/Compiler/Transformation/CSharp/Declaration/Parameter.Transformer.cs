using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitParameter(ParameterSyntax node)
        {
            var model = CreateSymbolic<ParameterDeclaration, ParameterDefinition>(node);
            model.DefaultExpression = TransformToSingleOrNull<ExpressionModel>(node.Default);

            yield return model;
        }
    }
}
