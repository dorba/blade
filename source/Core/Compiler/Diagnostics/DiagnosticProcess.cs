using Roslyn.Compilers;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Diagnostics
{
    /// <summary>
    /// Handles the diagnostic stage of the compilation process.
    /// </summary>
    internal class DiagnosticProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the diagnostic process.
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            if (context == null || context.Compilation == null)
                return;

            if (context.Result == null)
                context.Result = new CompilationResult();

            foreach (var item in context.Compilation.GetDiagnostics())
            {
                switch (item.Info.Severity)
                {
                    case DiagnosticSeverity.Error:
                        context.Result.AddError(CreateMessage(item));
                        break;

                    case DiagnosticSeverity.Warning:
                        context.Result.AddWarning(CreateMessage(item));
                        break;
                }
            }
        }

        // create a compilation message from a diagnostic item
        private static CompilationMessage CreateMessage(CommonDiagnostic item)
        {
            var inSource = item.Location.IsInSource;

            return new CompilationMessage
            {
                Message = item.Info.GetMessage(),
                FilePath = inSource ? item.Location.SourceTree.FilePath : null,
                Location = inSource ? DocumentLocation.FromSpan(item.Location.GetLineSpan(true)) : DocumentLocation.Default
            };
        }
    }
}
