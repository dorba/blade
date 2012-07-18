using System;
using System.Runtime.InteropServices;
using Blade.VisualStudio.Common;
using Microsoft.VisualStudio.Shell.Interop;

namespace Blade.VisualStudio.Projects
{
    /// <summary>
    /// The Blade Class Library project subtype.
    /// </summary>
    [Guid(LocalConstants.ClassLibraryProjectId)]
    public class BladeClassLibraryProject : BladeProjectBase
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="package">The registering package.</param>
        public BladeClassLibraryProject(BladePackage package)
            : base(package)
        {
        }

        protected override Guid GetGuidProperty(uint itemId, int propId)
        {
            switch (propId)
            {
                case (int)__VSHPROPID2.VSHPROPID_AddItemTemplatesGuid:
                    return typeof(BladeClassLibraryProjectFactory).GUID;
            }

            return base.GetGuidProperty(itemId, propId);
        }
    }
}
