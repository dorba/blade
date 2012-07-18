using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using Microsoft.CSharp;

namespace Blade.Compiler.Diagnostics
{
    /// <summary>
    /// Handles the intial build of the NET module.
    /// </summary>
    internal class BuildVerificationProcess : ICompilationProcess
    {
        /// <summary>
        /// Executes the module builder process
        /// </summary>
        /// <param name="context">The compilation context.</param>
        public void Execute(CompilationContext context)
        {
            if (context.Input == null)
                throw new CompilationException("The compilation input cannot be null.");

            // ensure the output directory is available
            if (!Directory.Exists(context.Input.TargetDirectory))
                Directory.CreateDirectory(context.Input.TargetDirectory);

            CompilerResults compileResult = null;

            using (var codeProvider = new CSharpCodeProvider())
            {
                // create compiler and options
                var options = new CompilerParameters
                {
                    GenerateExecutable = false,
                    GenerateInMemory = true,
                    IncludeDebugInformation = false,
                    CompilerOptions = "/t:library /noconfig /nostdlib"
                };

                // add referenced assemblies
                options.ReferencedAssemblies.AddRange(
                    context.Input.ReferencePaths.ToArray());

                // compile to module
                compileResult = codeProvider.CompileAssemblyFromFile(options,
                    context.Input.SourceFilePaths.ToArray());
            }

            // check for errors or warnings
            foreach (var item in compileResult.Errors.OfType<CompilerError>())
            {
                var msg = new CompilationMessage
                {
                    FilePath = item.FileName,
                    Message = item.ErrorText
                };

                if (item.IsWarning)
                    context.Result.AddWarning(msg);
                else context.Result.AddError(msg);
            }
        }
    }
}
