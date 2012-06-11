using System;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Data contract for a member declaration model.
    /// </summary>
    public interface IMemberDeclarationModel : IDeclarationModel
    {
        /// <summary>
        /// Gets or sets the member definition.
        /// </summary>
        new IMemberDefinition Definition { get; set; }

        /// <summary>
        /// Gets or set the containing declaration.
        /// </summary>
        ITypeDeclarationModel Container { get; set; }
    }
}
