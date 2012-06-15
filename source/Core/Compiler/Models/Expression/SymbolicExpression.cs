using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents an expression model which also has semantic meaning.
    /// </summary>
    public abstract class SymbolicExpression : ExpressionModel, ISymbolicModel
    {
        /// <summary>
        /// Gets or sets the definition model.
        /// </summary>
        public virtual IDefinition Definition { get; set; }

        /// <summary>
        /// Provides ease of access to definition static flag.
        /// </summary>
        public virtual bool IsStatic
        {
            get { return (Definition != null && Definition.Modifiers != null) ? Definition.Modifiers.IsStatic : false; }
        }

        /// <summary>
        /// Provides ease of access to the definition name.
        /// </summary>
        public virtual string Name
        {
            get { return (Definition != null) ? Definition.Name : ""; }
        }

        /// <summary>
        /// Provides ease of access to the definition full name.
        /// </summary>
        public virtual string FullName
        {
            get { return (Definition != null) ? Definition.GetFullName() : ""; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// Prevents external inheritance.
        /// </summary>
        internal SymbolicExpression()
        {
        }
    }
}
