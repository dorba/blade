
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Base for all expression models.
    /// </summary>
    public abstract class ExpressionModel : SyntacticModel
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// Prevents external inheritance.
        /// </summary>
        internal ExpressionModel()
        {
        }
    }
}
