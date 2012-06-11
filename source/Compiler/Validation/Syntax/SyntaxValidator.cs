using Roslyn.Compilers.Common;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// The base implementation for all syntax validators.
    /// </summary>
    /// <typeparam name="T">The syntax node type to validate.</typeparam>
    internal abstract class SyntaxValidator<T> : ISyntaxValidator
        where T : CommonSyntaxNode
    {
        private CommonSyntaxTree _currentTree;
        private CommonSyntaxNode _currentNode;
        private CompilationResult _currentResult;

        /// <summary>
        /// Validates the syntax node.
        /// </summary>
        /// <param name="node">The node to validate.</param>
        /// <param name="tree">The tree containing the node.</param>
        /// <param name="result">The compilation result.</param>
        public abstract void Validate(T node, CommonSyntaxTree tree, CompilationResult result);

        // explicit interface implementation
        void ISyntaxValidator.Validate(CommonSyntaxNode node, CommonSyntaxTree tree, CompilationResult result)
        {
            _currentTree = tree;
            _currentNode = node;
            _currentResult = result;

            Validate(node as T, tree, result);
        }

        /// <summary>
        /// Creates a new warning message associated with the current node.
        /// </summary>
        /// <param name="message">The message text.</param>
        protected void AddWarning(string message)
        {
            if (_currentResult != null)
            {
                _currentResult.AddWarning(new CompilationMessage
                {
                    FilePath = _currentTree != null ? _currentTree.FilePath : null,
                    Location = DocumentLocation.FromTreeNode(_currentTree, _currentNode),
                    Message = message
                });
            }
        }

        /// <summary>
        /// Creates a new error message associated with the current node.
        /// </summary>
        /// <param name="message">The message text.</param>
        protected void AddError(string message)
        {
            if (_currentResult != null)
            {
                _currentResult.AddError(new CompilationMessage
                {
                    FilePath = _currentTree != null ? _currentTree.FilePath : null,
                    Location = DocumentLocation.FromTreeNode(_currentTree, _currentNode),
                    Message = message
                });
            }
        }
    }
}