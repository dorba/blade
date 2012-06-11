using System;
using Roslyn.Compilers.CSharp;
using System.Collections.Generic;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Provides the contract for any class that will act as a model validator.
    /// </summary>
    internal interface IModelValidator
    {
        /// <summary>
        /// Validates the generated model.
        /// </summary>
        /// <param name="model">The compilation model.</param>
        /// <param name="result">The compilation result.</param>
        void Validate(CompilationModel model, CompilationResult result);
    }
}