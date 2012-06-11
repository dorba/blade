using System;
using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// The base implementation for all type declaration models.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class TypeDeclarationModel<T> : DeclarationModel<T>, ITypeDeclarationModel
        where T : class, ITypeDefinition
    {
        /// <summary>
        /// Explicit interface implementation.
        /// Gets the symbolic definition.
        /// </summary>
        ITypeDefinition ITypeDeclarationModel.Definition
        {
            get { return Definition; }
            set { Definition = value as T; }
        }

        /// <summary>
        /// Gets all available member declarations.
        /// </summary>
        /// <returns>A collection of member declarations.</returns>
        public virtual IEnumerable<IMemberDeclarationModel> GetMemberDeclarations()
        {
            return Enumerable.Empty<IMemberDeclarationModel>();
        }

        /// <summary>
        /// Adds a member to the type.
        /// </summary>
        /// <param name="member">The target member.</param>
        public virtual void AddMember(IMemberDeclarationModel member)
        {
        }

        /// <summary>
        /// Removes a member from the type.
        /// </summary>
        /// <param name="member">The target member.</param>
        public virtual void RemoveMember(IMemberDeclarationModel member)
        {
        }
    }
}
