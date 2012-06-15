using System.Collections.Generic;
using Blade.Compiler.Models;

namespace Blade.Compiler.Extensibility
{
    /// <summary>
    /// Base empty implementation of a transform extension.
    /// </summary>
    public abstract class Extension : IExtension
    {
        /// <summary>
        /// Extends a declaration.
        /// </summary>
        /// <param name="declaration">The target declaration.</param>
        /// <param name="model">The containing compilation model.</param>
        public virtual void ExtendDeclaration(IDeclarationModel declaration, CompilationModel model) { }

        /// <summary>
        /// Extends a definition.
        /// </summary>
        /// <param name="definition">The target definition.</param>
        public virtual void ExtendDefinition(IDefinition definition) { }

        /// <summary>
        /// Extends the completed compilation model.
        /// </summary>
        public virtual void ExtendCompilation(CompilationModel model) { }
    }
}
