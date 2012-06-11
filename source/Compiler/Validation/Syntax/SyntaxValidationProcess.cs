
namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Handles the syntax validation stage of the compilation process.
    /// </summary>
    internal class SyntaxValidationProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the syntax validation process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            var visitor = new SyntaxValidationVisitor(
                new SyntaxValidatorProvider(), context.Result);

            foreach (var tree in context.Compilation.SyntaxTrees)
            {
                visitor.CurrentTree = tree;
                visitor.Visit(tree.GetRoot());
            }
        }
    }
}
