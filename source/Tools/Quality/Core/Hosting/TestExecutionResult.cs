
namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// Represents the result of a single test execution.
    /// </summary>
    public sealed class TestExecutionResult
    {
        /// <summary>
        /// Gets a value indicating whether or not an error message is present.
        /// </summary>
        public bool HasError
        {
            get { return !string.IsNullOrWhiteSpace(ErrorMessage); }
        }

        /// <summary>
        /// Gets or sets the error message text.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}