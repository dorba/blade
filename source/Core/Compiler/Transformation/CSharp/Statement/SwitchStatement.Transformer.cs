using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitSwitchStatement(SwitchStatementSyntax node)
        {
            var model = Create<SwitchStatement>(node);
            model.Expression = TransformToSingle<ExpressionModel>(node.Expression);
            TransformInto<SwitchSection>(node.Sections, model.Sections);

            yield return model;
        }

        public override IEnumerable<IModel> VisitSwitchSection(SwitchSectionSyntax node)
        {
            var model = Create<SwitchSection>(node);
            model.IsDefault = node.Labels.Any(l => l.CaseOrDefaultKeyword.Kind == SyntaxKind.DefaultKeyword);
            TransformInto<ExpressionModel>(node.Labels, model.Labels);
            TransformInto<StatementModel>(node.Statements, model.Statements);

            yield return model;
        }

        public override IEnumerable<IModel> VisitSwitchLabel(SwitchLabelSyntax node)
        {
            return (node.Value != null) ?
                Visit(node.Value) :
                Enumerable.Empty<IModel>();
        }
    }
}
