using Microsoft.VisualStudio.Shell.Flavor;

namespace Blade.VisualStudio.Projects
{
    /// <summary>
    /// The base class for all Blade project factory classes.
    /// </summary>
    public abstract class BladeProjectFactoryBase : FlavoredProjectFactoryBase
    {
        /// <summary>
        /// Gets the registering package.
        /// </summary>
        protected BladePackage Package { get; private set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="package">The registering package.</param>
        public BladeProjectFactoryBase(BladePackage package)
        {
            Package = package;
        }
    }
}
