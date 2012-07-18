using System;
using System.IO;
using Blade.Compiler.Diagnostics;
using Blade.Compiler.Preprocessing;
using Blade.Compiler.Transformation;
using Blade.Compiler.Translation;
using Blade.Compiler.Validation;

namespace Blade.Compiler
{
    /// <summary>
    /// Blade compilation service API.
    /// </summary>
    public sealed class CompilationService
    {
        /// <summary>
        /// Compiles the specified input object.
        /// </summary>
        /// <param name="input">The compiler input information.</param>
        /// <returns>The compilation result.</returns>
        public CompilationResult Compile(CompilationRequest input)
        {
            if (input == null)
                throw new ArgumentNullException("input", "The compilation input cannot be null.");

            var pipeline = new CompilationPipeline();
            pipeline.AddProcess(new BuildVerificationProcess());
            pipeline.AddProcess(new SyntaxParsingProcess());
            pipeline.AddProcess(new SyntaxValidationProcess());
            pipeline.AddProcess(new PreprocessingProcess());
            pipeline.AddProcess(new TransformationProcess());
            pipeline.AddProcess(new ModelValidationProcess());
            pipeline.AddProcess(new TranslationProcess());

            using (var stream = File.Create(input.TargetPath + ".js"))
            {
                return pipeline.Execute(input, stream);
            }
        }
    }
}