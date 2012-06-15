using System;
using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers.Common;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Preprocessing.CSharp
{
    /// <summary>
    /// Base implementation for preprocessors that of C-Sharp syntax.
    /// </summary>
    internal abstract class Preprocessor : SyntaxRewriter, IPreprocessor
    {
        /// <summary>
        /// Gets the current semantic model.
        /// </summary>
        protected ISemanticModel Semantics { get; private set; }

        /// <summary>
        /// Executes the preprocessor.
        /// </summary>
        /// <param name="compilation">The compilation.</param>
        /// <returns>The processed compilation.</returns>
        public CommonCompilation ProcessCompilation(CommonCompilation compilation)
        {
            var cSharpComp = compilation as Compilation;
            if (cSharpComp == null)
                return compilation;

            var newTrees = new List<SyntaxTree>();

            foreach (var tree in cSharpComp.SyntaxTrees)
            {
                Semantics = compilation.GetSemanticModel(tree);
                var newRoot = (CompilationUnitSyntax)Visit(tree.GetRoot());

                newTrees.Add(SyntaxTree.Create(tree.FilePath, newRoot, tree.Options));
            }

            return compilation
                .RemoveAllSyntaxTrees()
                .AddSyntaxTrees(newTrees);
        }

        /// <summary>
        /// Gets any dependencies for this preprocessor.
        /// </summary>
        /// <returns>A collection of dependencies.</returns>
        public virtual IEnumerable<Type> GetDependencies()
        {
            return Enumerable.Empty<Type>();
        }
    }
}