
namespace Blade.Compiler
{
    /// <summary>
    /// The service contract for any class that will run in the compiler pipeline.
    /// </summary>
    internal interface ICompilationProcess
    {
        /// <summary>
        /// Executes the process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        void Execute(CompilationContext context);
    }
}