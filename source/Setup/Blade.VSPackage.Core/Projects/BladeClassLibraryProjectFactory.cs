using System;
using System.Runtime.InteropServices;
using Blade.VisualStudio.Common;

namespace Blade.VisualStudio.Projects
{
    /// <summary>
    /// The Blade Class Library project factory.
    /// </summary>
    [Guid(LocalConstants.ClassLibraryProjectFactoryId)]
    public class BladeClassLibraryProjectFactory : BladeProjectFactoryBase
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="package">The registering package.</param>
        public BladeClassLibraryProjectFactory(BladePackage package)
            : base(package)
        {
        }

        protected override object PreCreateForOuter(IntPtr outerProjectIUnknown)
        {
            return new BladeClassLibraryProject(Package);
        }
    }
}
