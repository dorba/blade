using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// The base implementation for all translator classes.
    /// </summary>
    /// <typeparam name="T">The model type.</typeparam>
    internal abstract class Translator<T> : ITranslator
        where T : class, IModel
    {
        /// <summary>
        /// Translates the model in script.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="context">The translation context.</param>
        public abstract void Translate(T model, TranslationContext context);

        // explicit interface implementation
        void ITranslator.Translate(IModel model, TranslationContext context)
        {
            Translate(model as T, context);
        }
    }
}
