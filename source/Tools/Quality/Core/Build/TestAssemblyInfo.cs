
namespace Blade.Tools.Quality.Build
{
    /// <summary>
    /// Provides details used for building a test assembly.
    /// </summary>
    internal class TestAssemblyInfo
    {
        /// <summary>
        /// Gets or sets the directory of the test project.
        /// </summary>
        public string ProjectDir { get; set; }

        /// <summary>
        /// Gets or sets the output path of the generated assembly.
        /// </summary>
        public string OutputPath { get; set; }
    }
}
