using System;
using System.Runtime.InteropServices;
using Blade.VisualStudio.Common;

namespace Blade.VisualStudio.Projects
{
    /// <summary>
    /// The Blade Unit Test project factory.
    /// </summary>
    [Guid(LocalConstants.UnitTestProjectFactoryId)]
    public class BladeUnitTestProjectFactory : BladeProjectFactoryBase
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="package">The registering package.</param>
        public BladeUnitTestProjectFactory(BladePackage package)
            : base(package)
        {
        }

        protected override object PreCreateForOuter(IntPtr outerProjectIUnknown)
        {
            return new BladeUnitTestProject(Package);
        }
    }
}
