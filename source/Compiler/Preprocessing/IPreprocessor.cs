using System;
using System.Collections.Generic;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Preprocessing
{
    /// <summary>
    /// Provides the contract for any class that will act as a preprocessor to the script compiler.
    /// </summary>
    internal interface IPreprocessor
    {
        /// <summary>
        /// Executes a preprocessor againt the compilation.
        /// </summary>
        /// <param name="compilation">The input compilation.</param>
        /// <returns>The resulting compilation</returns>
        CommonCompilation ProcessCompilation(CommonCompilation compilation);

        /// <summary>
        /// Gets other preprocessors that should run prior to this one.
        /// </summary>
        /// <returns>A collection of preprocessor types.</returns>
        IEnumerable<Type> GetDependencies();
    }
}