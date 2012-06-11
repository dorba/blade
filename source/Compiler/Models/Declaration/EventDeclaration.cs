
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a single event declaration.
    /// </summary>
    public sealed class EventDeclaration : MemberDeclarationModel<EventDefinition>
    {
        /// <summary>
        /// Gets or sets the add accessor block.
        /// </summary>
        public CodeBlock AddAccessor { get; set; }

        /// <summary>
        /// Gets or sets the remove accessor block.
        /// </summary>
        public CodeBlock RemoveAccessor { get; set; }

        /// <summary>
        /// Gets a value indicating if the event is declared as a field.
        /// </summary>
        public bool IsField
        {
            get { return AddAccessor == null && RemoveAccessor == null; }
        }
    }
}
