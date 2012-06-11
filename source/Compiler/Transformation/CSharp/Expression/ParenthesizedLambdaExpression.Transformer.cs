using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            var model = Create<LambdaExpression>(node);
            model.Body = TransformToSingle<ISyntacticModel>(node.Body);
            TransformInto<ParameterDeclaration>(node.ParameterList, model.Parameters);

            yield return model;
        }
    }
}
