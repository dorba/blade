
namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents a code statement.
    /// </summary>
    public abstract class StatementModel : SyntacticModel
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// Prevent external inheritance.
        /// </summary>
        internal StatementModel()
        {
        }
    }
}
