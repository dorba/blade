using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an intitializer expression.
    /// </summary>
    public sealed class InitializerExpression : ExpressionModel
    {
        /// <summary>
        /// Gets the expressions.
        /// </summary>
        public IList<ExpressionModel> Expressions
        {
            get { return _expressions; }
        } private List<ExpressionModel> _expressions;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public InitializerExpression()
        {
            _expressions = new List<ExpressionModel>();
        }
    }
}
