using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;
using System;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            var model = Create<MemberAccessExpression>(node);

            // globally named items such as namespaces and type names
            // are evaluated at translation time, from the definition
            // they are not included in the model
            if (!HasGlobalName(node.Expression))
                model.Expression = TransformToSingle<ExpressionModel>(node.Expression);

            model.Member = TransformToSingle<IdentifierName>(node.Name);

            yield return model;
        }

        // determine if an expression has a global name
        private bool HasGlobalName(ExpressionSyntax node)
        {
            var memberAccess = node as MemberAccessExpressionSyntax;
            if (memberAccess != null)
                return HasGlobalName(memberAccess.Name);

            var name = node as NameSyntax;
            if (name == null)
                return false;

            var def = GetDefinition<IDefinition>(name);

            if (def == null)
                return false;

            if (def.Kind == DefinitionKind.Namespace)
                return true;

            if (def.Kind == DefinitionKind.Type)
                return true;

            return false;
        }
    }
}
