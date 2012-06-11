using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a property declaration.
    /// </summary>
    public sealed class PropertyDeclaration : MemberDeclarationModel<PropertyDefinition>
    {
        /// <summary>
        /// Gets or sets the get accessor block.
        /// </summary>
        public CodeBlock GetAccessor { get; set; }

        /// <summary>
        /// Gets a value indicating if the property has a get accessor assigned.
        /// </summary>
        public bool HasGetter
        {
            get { return GetAccessor != null; }
        }

        /// <summary>
        /// Gets or sets the set accessor block.
        /// </summary>
        public CodeBlock SetAccessor { get; set; }

        /// <summary>
        /// Gets a value indicating if the property has a set accessor assigned.
        /// </summary>
        public bool HasSetter
        {
            get { return SetAccessor != null; }
        }

        /// <summary>
        /// Gets a value indicating if the property is declared as an auto-property.
        /// </summary>
        public bool IsAutoProperty
        {
            get { return !(HasGetter | HasSetter); }
        }
    }
}
