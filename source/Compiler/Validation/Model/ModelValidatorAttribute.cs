using System;
using System.ComponentModel.Composition;

namespace Blade.Compiler.Validation
{
    /// <summary>
    /// Specifies that a class will be exported as a model validator.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    internal class ModelValidatorAttribute : ExportAttribute
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public ModelValidatorAttribute()
            : base(typeof(IModelValidator))
        {
        }
    }
}