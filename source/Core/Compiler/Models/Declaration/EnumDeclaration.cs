using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an enum declaration.
    /// </summary>
    public sealed class EnumDeclaration : TypeDeclarationModel<EnumDefinition>
    {
        /// <summary>
        /// Gets the enum member models.
        /// </summary>
        public IList<EnumMemberDeclaration> Members
        {
            get { return _members; }
        } private List<EnumMemberDeclaration> _members;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public EnumDeclaration()
        {
            _members = new List<EnumMemberDeclaration>();
        }
    }
}
