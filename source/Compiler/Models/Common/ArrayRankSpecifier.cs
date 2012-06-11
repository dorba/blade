using System;
using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an array rank specifier.
    /// </summary>
    public sealed class ArrayRankSpecifier : SyntacticModel
    {
        /// <summary>
        /// Gets or sets the array rank.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Gets the array size expressions, in order.
        /// </summary>
        public IList<ExpressionModel> Sizes
        {
            get { return _sizes; }
        } private List<ExpressionModel> _sizes;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ArrayRankSpecifier()
        {
            _sizes = new List<ExpressionModel>();
        }
    }
}
