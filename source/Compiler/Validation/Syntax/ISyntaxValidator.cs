using Roslyn.Compilers.Common;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Provides the contract for any class that will act as a syntax validator.
    /// </summary>
    internal interface ISyntaxValidator
    {
        /// <summary>
        /// Validates the syntax node.
        /// </summary>
        /// <param name="node">The node to validate.</param>
        /// <param name="tree">The tree containing the node.</param>
        /// <param name="result">The compilation result.</param>
        void Validate(CommonSyntaxNode node, CommonSyntaxTree tree, CompilationResult result);
    }
}