using Blade.Compiler.Models;

namespace Blade.Compiler.Translation
{
    /// <summary>
    /// Marks a fixed position in the translation context for deferred writing.
    /// </summary>
    internal sealed class PositionalWriter
    {
        private TranslationContext _context;
        private int _position;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="context">The translation context.</param>
        /// <param name="position">The writing position.</param>
        public PositionalWriter(TranslationContext context, int position)
        {
            _context = context;
            _position = position;
        }

        /// <summary>
        /// Writes a string to the underlying context.
        /// </summary>
        /// <param name="value">The value to write.</param>
        public void Write(string value)
        {
            _context.WriteAt(_position, value);
        }
    }
}
