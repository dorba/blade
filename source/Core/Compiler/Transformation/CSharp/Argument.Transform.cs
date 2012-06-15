using System;
using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitArgument(ArgumentSyntax node)
        {
            var model = Create<Argument>(node);
            model.Expression = TransformToSingleOrNull<ExpressionModel>(node.Expression);

            if (node.NameColon != null)
                model.ParameterName = node.NameColon.Identifier.Identifier.ValueText;

            yield return model;
        }

        public override IEnumerable<IModel> VisitArgumentList(ArgumentListSyntax node)
        {
            return Transform(node.Arguments);
        }
    }
}
