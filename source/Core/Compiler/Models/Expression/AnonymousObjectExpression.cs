using System;
using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an anonymous object creation.
    /// </summary>
    public sealed class AnonymousObjectExpression : ExpressionModel
    {
        /// <summary>
        /// Gets or sets the object assignments.
        /// </summary>
        public IList<AssignmentExpression> Assignments
        {
            get { return _assignments; }
        } private List<AssignmentExpression> _assignments;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public AnonymousObjectExpression()
        {
            _assignments = new List<AssignmentExpression>();
        }
    }
}
