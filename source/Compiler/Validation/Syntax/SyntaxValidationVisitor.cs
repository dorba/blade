using Roslyn.Compilers.Common;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Visits each syntax in a tree, applying syntax validation
    /// </summary>
    internal class SyntaxValidationVisitor : CommonSyntaxWalker
    {
        private CompilationResult _result;
        private SyntaxValidatorProvider _provider;

        /// <summary>
        /// Gets or sets the current syntax tree.
        /// </summary>
        public CommonSyntaxTree CurrentTree { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public SyntaxValidationVisitor(SyntaxValidatorProvider provider, CompilationResult result)
        {
            _provider = provider;
            _result = result;
        }

        public override void Visit(CommonSyntaxNode node)
        {
            var validator = _provider.ResolveImport(node.GetType());

            if (validator != null)
                validator.Validate(node, CurrentTree, _result);

            base.Visit(node);
        }
    }
}
