
namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Handles the model validation stage of the compilation process.
    /// </summary>
    internal class ModelValidationProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the model validation process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            var provider = new ImportProvider<IModelValidator>();

            foreach (var validator in provider.GetImports())
            {
                validator.Validate(context.Model, context.Result);
            }
        }
    }
}
