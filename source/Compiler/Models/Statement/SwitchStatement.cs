using System;
using System.Collections.Generic;
using System.Linq;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a switch statement.
    /// </summary>
    public sealed class SwitchStatement : StatementModel
    {
        /// <summary>
        /// Gets or sets the switch expression.
        /// </summary>
        public ExpressionModel Expression { get; set; }

        /// <summary>
        /// Gets the switch sections.
        /// </summary>
        public IList<SwitchSection> Sections
        {
            get { return _sections; }
        } private List<SwitchSection> _sections;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public SwitchStatement()
        {
            _sections = new List<SwitchSection>();
        }
    }
}
