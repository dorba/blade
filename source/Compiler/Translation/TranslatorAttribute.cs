using System;
using System.ComponentModel.Composition;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// For use internally to easily export a translator object via MEF.
    /// </summary>
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    internal class TranslatorAttribute : ExportAttribute
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public TranslatorAttribute()
            : base(typeof(ITranslator))
        {
        }
    }
}
