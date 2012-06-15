using System;
using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers.Common;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Data contract for a type declaration model.
    /// </summary>
    public interface ITypeDeclarationModel : IDeclarationModel
    {
        /// <summary>
        /// Gets or sets the type definition.
        /// </summary>
        new ITypeDefinition Definition { get; set; }

        /// <summary>
        /// Gets all available member declarations.
        /// </summary>
        /// <returns>A collection of member declarations.</returns>
        IEnumerable<IMemberDeclarationModel> GetMemberDeclarations();

        /// <summary>
        /// Adds a member to the type.
        /// </summary>
        /// <param name="member">The target member.</param>
        void AddMember(IMemberDeclarationModel member);

        /// <summary>
        /// Removes a member from the type.
        /// </summary>
        /// <param name="member">The target member.</param>
        void RemoveMember(IMemberDeclarationModel member);
    }
}
