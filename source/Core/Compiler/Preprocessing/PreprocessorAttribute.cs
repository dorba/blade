using System;
using System.ComponentModel.Composition;

namespace Blade.Compiler.Preprocessing
{
    /// <summary>
    /// Specifies that a class will be exported as a preprocessor.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    internal class PreprocessorAttribute : ExportAttribute
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public PreprocessorAttribute()
            : base(typeof(IPreprocessor))
        {
        }
    }
}