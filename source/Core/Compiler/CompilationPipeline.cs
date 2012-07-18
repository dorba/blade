using System.Collections.Generic;
using Roslyn.Compilers.Common;
using System.IO;
using Blade.Compiler.Models;
using System;

namespace Blade.Compiler
{
    /// <summary>
    /// Executes each stage of the compilation process.
    /// </summary>
    internal class CompilationPipeline
    {
        private List<ICompilationProcess> _processes;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public CompilationPipeline()
        {
            _processes = new List<ICompilationProcess>();
        }

        /// <summary>
        /// Adds a new stage to the pipeline.
        /// </summary>
        /// <param name="process"></param>
        public void AddProcess(ICompilationProcess process)
        {
            _processes.Add(process);
        }

        /// <summary>
        /// Executes the compilation process.
        /// </summary>
        /// <param name="compilation">The compilation object.</param>
        /// <param name="outputStream">The output stream to write to.</param>
        /// <returns>The compilation result.</returns>
        public CompilationResult Execute(CompilationRequest input, Stream outputStream)
        {
            var context = new CompilationContext
            {
                Input = input,
                OutputStream = outputStream,
                Result = new CompilationResult()
            };

            // this locks the current scope
            ModelRegistry.BeginRegistration();
            var profiler = new ProcessProfiler();

            try
            {
                foreach (var proc in _processes)
                {
                    profiler.Execute(proc, context);
                    if (context.Result.HasErrors)
                        break;
                }
            }
            catch (CompilationException compEx)
            {
                context.Result.AddError(compEx.ToErrorMessage());
            }
            catch (Exception ex)
            {
                context.Result.AddError("Unexpected Error: " + ex.Message);
            }
            finally
            {
                // release lock
                ModelRegistry.EndRegistration();
                profiler.End();
            }

            return context.Result;
        }
    }
}