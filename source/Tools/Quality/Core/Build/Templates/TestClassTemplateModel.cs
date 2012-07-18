using System;
using System.Collections.Generic;

namespace Blade.Tools.Quality.Build.Templates
{
    /// <summary>
    /// Data container for a <see cref="ClassTemplate"/> object.
    /// </summary>
    public sealed class TestClassTemplateModel
    {
        /// <summary>
        /// Gets or sets the class name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the class namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets the class full name.
        /// </summary>
        public string FullName
        {
            get
            {
                if (String.IsNullOrWhiteSpace(Namespace))
                    return Name;

                return Namespace + "." + Name;
            }
        }

        /// <summary>
        /// Gets or sets the methods names.
        /// </summary>
        public IEnumerable<string> Methods { get; set; }
    }
}
