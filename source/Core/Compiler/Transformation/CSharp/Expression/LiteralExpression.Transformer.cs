using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;
using System;
using System.Globalization;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            var model = Create<LiteralExpression>(node);
            model.Type = GetLiteralType(node.Kind);
            if (model.Type == LiteralType.Number)
                model.Text = Convert.ToString(node.Token.Value, CultureInfo.InvariantCulture);
            else
                model.Text = node.Token.ValueText;

            yield return model;
        }

        private LiteralType GetLiteralType(SyntaxKind syntaxKind)
        {
            switch (syntaxKind)
            {
                case SyntaxKind.CharacterLiteralExpression: return LiteralType.Character;
                case SyntaxKind.StringLiteralExpression: return LiteralType.String;
                case SyntaxKind.NumericLiteralExpression: return LiteralType.Number;
                case SyntaxKind.NullLiteralExpression: return LiteralType.Null;

                case SyntaxKind.FalseLiteralExpression:
                case SyntaxKind.TrueLiteralExpression:
                    return LiteralType.Boolean;

                default: return LiteralType.None;
            }
        }
    }
}
