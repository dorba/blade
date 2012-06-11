using System;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// The base implementation for all member decelaration models.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MemberDeclarationModel<T> : DeclarationModel<T>, IMemberDeclarationModel
        where T : class, IMemberDefinition
    {
        /// <summary>
        /// Explicit interface implementation.
        /// Gets the symbolic definition.
        /// </summary>
        IMemberDefinition IMemberDeclarationModel.Definition
        {
            get { return Definition; }
            set { Definition = value as T; }
        }

        public ITypeDeclarationModel Container { get; set; }
    }
}
