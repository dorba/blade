using System;
using System.Linq;
using Blade.Compiler.Models;
using Blade.Compiler.Extensibility;

namespace Blade.Compiler.Transformation
{
    /// <summary>
    /// Handles the transformation stage of the compilation process.
    /// </summary>
    internal class TransformationProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the transformation process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            if (context == null || context.Compilation == null)
                return;

            if (context.Model == null)
                context.Model = new CompilationModel();

            if (context.Compilation is Roslyn.Compilers.CSharp.Compilation)
                TransformCSharp(context);
            else if (context.Compilation is Roslyn.Compilers.VisualBasic.Compilation)
                TransformVisualBasic(context);
            else throw new NotImplementedException("Transformation not implemented for compilation of type: " + context.Compilation.GetType().FullName);

            if (!context.Result.HasErrors)
            {
                ModelRegistry.Current.ExtendCompilation(context.Model, context.Compilation.Assembly);
            }
        }

        // handle c-sharp compilations
        private void TransformCSharp(CompilationContext context)
        {
            var compilation = context.Compilation as Roslyn.Compilers.CSharp.Compilation;
            var transformer = new CSharp.Transformer();

            foreach (var tree in compilation.SyntaxTrees)
            {
                var root = tree.GetRoot() as Roslyn.Compilers.CSharp.CompilationUnitSyntax;
                if (root == null)
                    continue;

                transformer.Semantics = compilation.GetSemanticModel(tree);
                var model = transformer.Visit(root).Single() as CompilationModel;

                context.Model.Merge(model);
            }

            foreach (var item in transformer.Warnings)
                context.Result.AddWarning(item);

            foreach (var item in transformer.Errors)
                context.Result.AddError(item);
        }

        // handle visual basic compilations
        private void TransformVisualBasic(CompilationContext context)
        {
            throw new NotImplementedException("Visual Basic transformation is not implemented.");
        }
    }
}