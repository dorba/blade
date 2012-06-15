using System;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Common interface for all declaration models.
    /// </summary>
    public interface IDeclarationModel : ISymbolicModel, ISyntacticModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the static flag.
        /// </summary>
        bool IsStatic { get; set; }
    }
}
