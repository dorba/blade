using System;
using System.ComponentModel.Composition;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Specifies that a class will be exported as a syntax validator.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    internal class SyntaxValidatorAttribute : ExportAttribute
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public SyntaxValidatorAttribute()
            : base(typeof(ISyntaxValidator))
        {
        }
    }
}