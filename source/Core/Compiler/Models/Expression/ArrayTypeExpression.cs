using System;
using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an array type expression.
    /// </summary>
    public sealed class ArrayTypeExpression : SymbolicExpression
    {
        /// <summary>
        /// Gets or sets the array type.
        /// </summary>
        public ITypeDefinition ElementType { get; set; }

        /// <summary>
        /// Gets the array rank expressions, in order.
        /// </summary>
        public IList<ArrayRankSpecifier> RankExpressions
        {
            get { return _rankExpressions; }
        } private List<ArrayRankSpecifier> _rankExpressions;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ArrayTypeExpression()
        {
            _rankExpressions = new List<ArrayRankSpecifier>();
        }
    }
}
