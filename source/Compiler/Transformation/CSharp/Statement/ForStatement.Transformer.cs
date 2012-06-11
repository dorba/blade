using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitForStatement(ForStatementSyntax node)
        {
            var model = Create<ForStatement>(node);
            model.Condition = TransformToSingleOrNull<ExpressionModel>(node.Condition);
            model.VariableDeclaration = TransformToSingleOrNull<VariableDeclaration>(node.Declaration);
            model.Statement = TransformToSingle<StatementModel>(node.Statement);
            TransformInto<ExpressionModel>(node.Initializers, model.Initializers);
            TransformInto<ExpressionModel>(node.Incrementors, model.Incrementors);

            yield return model;
        }
    }
}
