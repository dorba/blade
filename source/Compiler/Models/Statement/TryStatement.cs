using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a try statement.
    /// </summary>
    public sealed class TryStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the try statement body.
        /// </summary>
        public CodeBlock Body { get; set; }

        /// <summary>
        /// Gets the catch statements.
        /// </summary>
        public IList<CatchStatement> Catches
        {
            get { return _catches; }
        }        private List<CatchStatement> _catches;

        /// <summary>
        /// Gets a value indicating if the try statement has any catch blocks.
        /// </summary>
        public bool HasCatch
        {
            get { return Catches != null && Catches.Any(); }
        }

        /// <summary>
        /// Gets or sets the finally statement body.
        /// </summary>
        public CodeBlock FinallyBody { get; set; }

        /// <summary>
        /// Gets a value indicating if the try statement has a finally block.
        /// </summary>
        public bool HasFinally
        {
            get { return FinallyBody != null; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public TryStatement()
        {
            _catches = new List<CatchStatement>();
        }
    }
}
