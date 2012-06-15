
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a single field declaration.
    /// </summary>
    public sealed class FieldDeclaration : MemberDeclarationModel<FieldDefinition>
    {
        /// <summary>
        /// Gets or sets the field initializer.
        /// </summary>
        public ExpressionModel Initializer { get; set; }
    }
}
