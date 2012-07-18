using System;
using System.Runtime.InteropServices;
using Blade.VisualStudio.Common;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell.Interop;

namespace Blade.VisualStudio.Projects
{
    /// <summary>
    /// The Blade Unit Test project type.
    /// </summary>
    [Guid(LocalConstants.UnitTestProjectId)]
    public class BladeUnitTestProject : BladeProjectBase
    {
        private static readonly Guid UnitTestMenuItemsGroupId =
            new Guid("E3BC1C4F-9E6C-9709-A304-1B2BC6AF5D32");

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="package">The registering package.</param>
        public BladeUnitTestProject(BladePackage package)
            : base(package)
        {
        }

        protected override Guid GetGuidProperty(uint itemId, int propId)
        {
            switch (propId)
            {
                case (int)__VSHPROPID2.VSHPROPID_AddItemTemplatesGuid:
                    return typeof(BladeUnitTestProjectFactory).GUID;
            }

            return base.GetGuidProperty(itemId, propId);
        }

        protected override int QueryStatusCommand(uint itemid, ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
        {
            // this removes the unit test related items from the 
            // add new item context menu. adding a new test in a
            // blade unit test is always done by adding a new file
            if (pguidCmdGroup == UnitTestMenuItemsGroupId)
                return DisableCommand(ref prgCmds[0]);

            return base.QueryStatusCommand(itemid, ref pguidCmdGroup, cCmds, prgCmds, pCmdText);
        }
    }
}
