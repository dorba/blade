
namespace Blade.Compiler.Models
{
    public interface ITypeDefinition : IDefinition
    {
        /// <summary>
        /// Gets or sets the type definition kind.
        /// </summary>
        TypeDefinitionKind TypeKind { get; set; }

        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        string Namespace { get; set; }
    }
}
