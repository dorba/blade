using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Service contract for any class that will perform model translation.
    /// </summary>
    internal interface ITranslator
    {
        /// <summary>
        /// Translates the model in script.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="context">The translation context.</param>
        void Translate(IModel model, TranslationContext context);
    }


}
