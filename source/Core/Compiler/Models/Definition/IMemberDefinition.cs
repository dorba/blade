
namespace Blade.Compiler.Models
{
    public interface IMemberDefinition : IDefinition
    {
        /// <summary>
        /// Gets or sets the member definition kind.
        /// </summary>
        MemberDefinitionKind MemberKind { get; set; }

        /// <summary>
        /// Gets or sets the containing type.
        /// </summary>
        ITypeDefinition ContainingType { get; set; }
    }
}
