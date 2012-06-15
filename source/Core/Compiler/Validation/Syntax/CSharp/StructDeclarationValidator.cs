using Roslyn.Compilers.Common;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Validation.CSharp
{
    [SyntaxValidator]
    internal class StructDeclarationValidator: SyntaxValidator<StructDeclarationSyntax>
    {
        /// <summary>
        /// Validates the syntax node.
        /// </summary>
        /// <param name="node">The node to validate.</param>
        /// <param name="tree">The tree containing the node.</param>
        /// <param name="result">The compilation result.</param>
        public override void Validate(StructDeclarationSyntax node, CommonSyntaxTree tree, CompilationResult result)
        {
            AddError("Struct declarations are not supported. Consider using a Class declaration instead.");
        }
    }
}