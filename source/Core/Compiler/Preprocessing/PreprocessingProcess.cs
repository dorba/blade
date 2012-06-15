
namespace Blade.Compiler.Preprocessing
{
    /// <summary>
    /// Handles the syntax preprocessing stage of the compilation process.
    /// </summary>
    internal class PreprocessingProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the preprocessing process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            if (context == null || context.Compilation == null)
                return;

            // get local imports
            var provider = new ImportProvider<IPreprocessor>(null);
            var sorter = new PreprocessorSorter();

            foreach (var preprocessor in sorter.Sort(provider.GetImports()))
            {
                context.Compilation = preprocessor.ProcessCompilation(context.Compilation);
            }
        }
    }
}
