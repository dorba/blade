using System;
using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        private List<CompilationMessage> _warnings;
        private List<CompilationMessage> _errors;

        /// <summary>
        /// Gets or sets the semantic model.
        /// </summary>
        public SemanticModel Semantics { get; set; }

        /// <summary>
        /// Gets the warnings during by the generation process.
        /// </summary>
        public IEnumerable<CompilationMessage> Warnings
        {
            get { return _warnings; }
        }

        /// <summary>
        /// Gets the errors during by the generation process.
        /// </summary>
        public IEnumerable<CompilationMessage> Errors
        {
            get { return _errors; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public Transformer()
        {
            _warnings = new List<CompilationMessage>();
            _errors = new List<CompilationMessage>();
        }

        // this method is called by every visitation request
        public override IEnumerable<IModel> Visit(SyntaxNode node)
        {
            // Note: this is a common handler for all nodes.
            // If a need arises to execute some additional code
            // before or after visitation, this is the place for it.
            return base.Visit(node);
        }

        // default visitation method, called when no visitation overload is present
        public override IEnumerable<IModel> DefaultVisit(SyntaxNode node)
        {
            // get a friendly readable name from the type name
            // for example, this turns something like
            // "ClassDeclarationSyntax" into "Class Declaration"

            var name = new String(
                node.GetType().Name
                .Replace("Syntax", String.Empty)
                .SelectMany(c => Char.IsUpper(c) ?
                    new[] { ' ', c } :
                    new[] { c })
                .ToArray())
                .Trim();

            // pushes an error message back up to the IDE that the syntax is not supported.
            throw new CompilationException(name + "s are not supported.", Create<SyntacticModel>(node));
        }

        #region Helper Methods

        private void AddWarning(string message, SyntaxNode node = null)
        {
            var msg = new CompilationMessage();
            msg.Message = message;

            if (Semantics != null && Semantics.SyntaxTree != null)
            {
                msg.FilePath = Semantics.SyntaxTree.FilePath;
                msg.Location = DocumentLocation.FromTreeNode(Semantics.SyntaxTree, node);
            }

            _warnings.Add(msg);
        }

        private void AddError(string message, SyntaxNode node = null)
        {
            var msg = new CompilationMessage();
            msg.Message = message;

            if (Semantics != null && Semantics.SyntaxTree != null)
            {
                msg.FilePath = Semantics.SyntaxTree.FilePath;
                msg.Location = DocumentLocation.FromTreeNode(Semantics.SyntaxTree, node);
            }

            _errors.Add(msg);
        }

        /// <summary>
        /// Transforms a single syntax node into a list.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="node">The node to transform.</param>
        /// <param name="target">The list to fill.</param>
        private void TransformInto<T>(SyntaxNode node, IList<T> target)
            where T : IModel
        {
            if (node == null)
                return;

            var results = Visit(node).Cast<T>();

            foreach (var item in results)
                target.Add(item);
        }

        /// <summary>
        /// Transforms a collection of nodes into a list.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="nodes">The nodes to transform.</param>
        /// <param name="target">The list to fill.</param>
        private void TransformInto<T>(IEnumerable<SyntaxNode> nodes, IList<T> target)
            where T : IModel
        {
            if (nodes == null)
                return;

            var results = nodes.SelectMany(n => Visit(n)).Cast<T>();

            foreach (var item in results)
                target.Add(item);
        }

        /// <summary>
        /// Transforms a set of nodes.
        /// </summary>
        /// <param name="nodes">The nodes to transform.</param>
        /// <returns>The resulting models.</returns>
        private IEnumerable<IModel> Transform(IEnumerable<SyntaxNode> nodes)
        {
            return (nodes != null) ?
                nodes.SelectMany(n => Visit(n)) :
                Enumerable.Empty<IModel>();
        }

        /// <summary>
        /// Transforms a node, and expects a single result.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="node">The node to transform.</param>
        /// <returns>The result.</returns>
        private T TransformToSingle<T>(SyntaxNode node)
            where T : class, IModel
        {
            if (node == null)
                return null;

            return (T)Visit(node).Single();
        }

        /// <summary>
        /// Transforms a node, and expects either a single result of none.
        /// Creates a new model if the transform results in an empty or null value.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="node">The node to transform.</param>
        /// <returns>The result.</returns>
        private T TransformToSingleOrNew<T>(SyntaxNode node)
            where T : class, IModel, new()
        {
            if (node == null)
                return new T();

            return (Visit(node).Single() as T) ?? new T();
        }

        /// <summary>
        /// Transforms a node, and expects either a single result of none.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="node">The node to transform.</param>
        /// <returns>The result.</returns>
        private T TransformToSingleOrNull<T>(SyntaxNode node)
            where T : class, IModel
        {
            if (node == null)
                return null;

            return Visit(node).SingleOrDefault() as T;
        }

        /// <summary>
        /// Creates a new model from a syntax node.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="node">The node to create from.</param>
        /// <returns>A new model.</returns>
        private T Create<T>(SyntaxNode node)
            where T : class, IModel, new()
        {
            if (node == null)
                return null;

            var model = new T();

            var syntaxModel = model as ISyntacticModel;
            if (syntaxModel != null)
            {
                syntaxModel.OriginatingNode = node;
                syntaxModel.OriginatingTree = Semantics.SyntaxTree;
            }

            return model;
        }

        /// <summary>
        /// Creates a new symbolic model.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <typeparam name="TDef">The definition type.</typeparam>
        /// <param name="node">The node to create from.</param>
        /// <param name="idName">An optional identifier name.</param>
        /// <returns>A new model.</returns>
        private T CreateSymbolic<T, TDef>(SyntaxNode node, string idName = null)
            where T : class, ISymbolicModel, new()
            where TDef : class, IDefinition
        {
            var model = Create<T>(node);
            if (model == null)
                return null;

            var symbol = GetSymbol(node, idName);

            if (symbol != null)
                model.Definition = ModelRegistry.Current.GetDefinition<TDef>(symbol);

            return model;
        }

        /// <summary>
        /// Gets the definition associated with a syntax node.
        /// </summary>
        /// <typeparam name="T">The definition type.</typeparam>
        /// <param name="node">The associated node.</param>
        /// <param name="idName">An optional identifier name.</param>
        /// <returns>A definition.</returns>
        private T GetDefinition<T>(SyntaxNode node, string idName = null)
            where T : class, IDefinition
        {
            var symbol = GetSymbol(node, idName);

            if (symbol == null)
                return null;

            return ModelRegistry.Current.GetDefinition<T>(symbol);
        }

        /// <summary>
        /// Gets the symbol of a node.
        /// </summary>
        /// <param name="node">The target node.</param>
        /// <returns>The associated symbol.</returns>
        private Symbol GetSymbol(IdentifierNameSyntax node)
        {
            return GetSymbol(node, node.Identifier.ValueText);
        }

        /// <summary>
        /// Gets the symbol of a node.
        /// </summary>
        /// <param name="node">The target node.</param>
        /// <param name="identifierName">An optional identifier name.</param>
        /// <returns>The associated symbol.</returns>
        private Symbol GetSymbol(SyntaxNode node, string identifierName = null)
        {
            Symbol symbol = null;

            // find symbol of declaration
            symbol = ((ISemanticModel)Semantics).GetDeclaredSymbol(node) as Symbol;

            if (symbol == null)
            {
                // find symbol of an expression
                var symbolInfo = ((ISemanticModel)Semantics).GetSymbolInfo(node);
                symbol = symbolInfo.Symbol as Symbol;

                if (symbol == null)
                {
                    if (symbolInfo.CandidateSymbols.Count == 1)
                        symbol = symbolInfo.CandidateSymbols[0] as Symbol;

                    // attempt using symbol lookup
                    if (symbol == null && identifierName != null)
                        symbol = Semantics.LookupSymbols(node.Span.Start, name: identifierName).SingleOrDefault();
                }
            }

            return symbol;
        }

        #endregion
    }
}
