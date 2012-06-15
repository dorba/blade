using System;
using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers.Common;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Preprocessing.CSharp
{
    /// <summary>
    /// Preprocesses member access expressions to ensure all instance
    /// member access is prefixed with the 'this' keyword.
    /// </summary>
    [Preprocessor]
    internal class InstanceMemberPreprocessor : Preprocessor
    {
        //public override SyntaxNode VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        //{
        //    // check for existing this prefix
        //    if (node.Expression.Kind == SyntaxKind.ThisExpression)
        //        return node;

        //    // find the candidate for this prefix
        //    var target = node.Expression.DescendantNodesAndSelf()
        //        .OfType<SimpleNameSyntax>().FirstOrDefault();

        //    if (target != null)
        //    {
        //        var result = Visit(target);

        //        if (result.Kind == SyntaxKind.MemberAccessExpression)
        //            return node.ReplaceNodes(new[] { target }, (o, n) => { return n; });
        //    }

        //    return node;
        //}

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            return RewriteSyntax(node);
        }

        public override SyntaxNode VisitGenericName(GenericNameSyntax node)
        {
            return RewriteSyntax(node);
        }

        #region Helper Methods

        // carries out the actual rewrite process, if required
        private SyntaxNode RewriteSyntax(SimpleNameSyntax node)
        {
            var symbol = GetSymbol(node);
            if (symbol == null)
                return node;

            if (IsCandidateForThis(node, symbol) &&
                ContainingTypeMatches(node, symbol.ContainingType))
            {
                // rewrite the syntax to include 'this' keyword
                return Syntax.MemberAccessExpression(
                    SyntaxKind.MemberAccessExpression,
                    Syntax.ThisExpression(
                        Syntax.Token(SyntaxKind.ThisKeyword)),
                    Syntax.Token(SyntaxKind.DotToken),
                    Syntax.IdentifierName(node.Identifier.ValueText));
            }

            return node;
        }

        // returns true if the idenfitier meets requirements
        // for adding the 'this' keyword prefix
        private bool IsCandidateForThis(SimpleNameSyntax node, ISymbol symbol)
        {
            if (symbol == null || symbol.ContainingType == null || symbol.IsStatic)
                return false;

            if (node.Parent.Kind == SyntaxKind.MemberAccessExpression)
            {
                var memberAcc = node.Parent as MemberAccessExpressionSyntax;
                if (memberAcc.Expression != node)
                    return false;
            }

            switch (symbol.Kind)
            {
                case CommonSymbolKind.Field:
                case CommonSymbolKind.Property:
                case CommonSymbolKind.Event:
                    return true;

                case CommonSymbolKind.Method:
                    if (((IMethodSymbol)symbol).MethodKind != CommonMethodKind.Constructor)
                        return true;
                    else break;
            }

            return false;
        }

        // return true the the physical container matches the specified symbol
        private bool ContainingTypeMatches(SimpleNameSyntax node, INamedTypeSymbol symbol)
        {
            TypeDeclarationSyntax value = null;
            var parent = node.Parent;

            while (parent != null)
            {
                value = parent as TypeDeclarationSyntax;
                if (value != null) break;

                parent = parent.Parent;
            }

            if (value == null)
                return false;

            return Semantics.GetDeclaredSymbol(value).Equals(symbol);
        }

        // get the symbol for from the identifier
        private ISymbol GetSymbol(SimpleNameSyntax node)
        {
            var info = Semantics.GetSymbolInfo(node);
            if (info.Symbol != null)
                return info.Symbol;

            if (info.CandidateSymbols.Count == 1)
                return info.CandidateSymbols[0];

            return null;
        }

        #endregion
    }
}