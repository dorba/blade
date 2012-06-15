using System;
using System.Collections.Generic;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a section within a switch statement.
    /// </summary>
    public sealed class SwitchSection : SyntacticModel
    {
        /// <summary>
        /// Gets the labels for the section.
        /// </summary>
        public IList<ExpressionModel> Labels
        {
            get { return _labels; }
        } List<ExpressionModel> _labels;

        /// <summary>
        /// Gets the statements for the section.
        /// </summary>
        public IList<StatementModel> Statements
        {
            get { return _statements; }
        } List<StatementModel> _statements;

        /// <summary>
        /// Gets or sets a value indicating whether or not this section contains the default case.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public SwitchSection()
        {
            _labels = new List<ExpressionModel>();
            _statements = new List<StatementModel>();
        }
    }
}
