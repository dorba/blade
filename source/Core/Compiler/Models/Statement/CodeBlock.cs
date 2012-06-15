using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represent a collection of expressions or statememts, with a specific context.
    /// </summary>
    public sealed class CodeBlock : StatementModel
    {
        /// <summary>
        /// Gets the statements collection.
        /// </summary>
        public IList<StatementModel> Statements
        {
            get { return _statements; }
        } private List<StatementModel> _statements;

        /// <summary>
        /// Gets or sets a value indicating if the block is enclosed in braces.
        /// </summary>
        public bool HasBraces
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public CodeBlock()
        {
            _statements = new List<StatementModel>();
        }
    }
}
