using System.Collections.Generic;
using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    /// <summary>
    /// Service contract for any class that will act as a transform extension.
    /// </summary>
    public interface IExtension
    {
        /// <summary>
        /// Extends a declaration.
        /// </summary>
        /// <param name="declaration">The target declaration.</param>
        /// <param name="model">The containing compilation model.</param>
        void ExtendDeclaration(IDeclarationModel declaration, CompilationModel model);

        /// <summary>
        /// Extends a definition.
        /// </summary>
        /// <param name="definition">The target definition.</param>
        void ExtendDefinition(IDefinition definition);

        /// <summary>
        /// Extends the completed compilation model.
        /// </summary>
        void ExtendCompilation(CompilationModel model);
    }
}
