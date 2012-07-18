using System;
using System.Collections.Generic;

namespace Blade.Tools.Quality.Build.Templates
{
    /// <summary>
    /// The template used to render test classes.
    /// </summary>
    public partial class TestClassTemplate
    {
        /// <summary>
        /// Gets or sets the template model.
        /// </summary>
        public TestClassTemplateModel Model { get; set; }
    }

    /// <summary>
    /// The templates used to provide init and cleanup hooks.
    /// </summary>
    public partial class InitClassTemplate
    {
        /// <summary>
        /// Gets or sets the directory containing the test project.
        /// </summary>
        public string ProjectDir { get; set; }
    }
}
