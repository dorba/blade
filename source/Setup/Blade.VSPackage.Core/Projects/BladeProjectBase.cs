using System;
using System.Linq;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Flavor;
using Microsoft.VisualStudio.Shell.Interop;

namespace Blade.VisualStudio.Projects
{
    /// <summary>
    /// The base class for all Blade subtype projects.
    /// </summary>
    public abstract class BladeProjectBase : FlavoredProjectBase, IVsProjectSpecialFiles
    {
        #region Static Constants

        // entirely excluded groups
        private static readonly Guid[] CmdGroupExclude = new[] {
            new Guid("79989DD6-4C13-4D10-9872-73538668D037"), // Calc Code Metrics
            new Guid("1492DB0A-85A2-4E43-BF0D-CE55B89A8CC6"), // Reset Interactive
            new Guid("25FD982B-8CAE-4CBD-A440-E03FFCCDE106")  // Manage Nuget Packages
        };

        // Cmd 97 Group exclusions
        private static readonly uint[] Cmd97Exclude = new[] {
            (uint)VSConstants.VSStd97CmdID.SetStartupProject
        };

        // Cmd 2k Group exclusions
        private static readonly uint[] Cmd2kExclude = new[] {
            (uint)1648, // Run Code Anaylsis
            (uint)VSConstants.VSStd2KCmdID.ADDWFCFORM,
            (uint)VSConstants.VSStd2KCmdID.ADDUSERCONTROL,
            (uint)VSConstants.VSStd2KCmdID.ADDTBXCOMPONENT,
            (uint)VSConstants.VSStd2KCmdID.PROJSTARTDEBUG,
            (uint)VSConstants.VSStd2KCmdID.PROJSTEPINTO
        };

        #endregion

        /// <summary>
        /// Creats a new instance of the class.
        /// </summary>
        /// <param name="package">The registering package.</param>
        public BladeProjectBase(BladePackage package)
        {
            serviceProvider = package;
        }

        #region IVsProjectSpecialFiles Members

        public int GetFile(int fileID, uint grfFlags, out uint pitemid, out string pbstrFilename)
        {
            pitemid = 0;
            pbstrFilename = "";

            if (fileID == (int)__PSFFILEID2.PSFFILEID_AppSettings ||
                fileID == (int)__PSFFILEID2.PSFFILEID_AssemblyResource)
            {
                // this keeps the Resources and Settings tabs from
                // rendering in the property pages dialog
                return VSConstants.E_FAIL;
            }

            return VSConstants.S_OK;
        }

        #endregion

        protected override int GetProperty(uint itemId, int propId, out object property)
        {
            switch (propId)
            {
                case (int)__VSHPROPID2.VSHPROPID_PropertyPagesCLSIDList:
                case (int)__VSHPROPID2.VSHPROPID_CfgPropertyPagesCLSIDList:
                case (int)__VSHPROPID2.VSHPROPID_PriorityPropertyPagesCLSIDList:
                    base.GetProperty(itemId, propId, out property);
                    property = ExcludePropertyPages((string)property);
                    return VSConstants.S_OK;
            }

            return base.GetProperty(itemId, propId, out property);
        }

        protected override int ExecCommand(uint itemid, ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            if (pguidCmdGroup == VsMenus.guidStandardCommandSet2K)
            {
                if (nCmdID == (uint)VSConstants.VSStd2KCmdID.ADDREFERENCE)
                {
                    // this can be used to override the default add references dialog
                    // TODO show an appropriate add-references dialog
                    //return VSConstants.S_OK;
                }
            }

            return base.ExecCommand(itemid, ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
        }

        protected override int QueryStatusCommand(uint itemid, ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
        {
            if (pguidCmdGroup == VsMenus.guidStandardCommandSet97)
            {
                if (Cmd97Exclude.Contains(prgCmds[0].cmdID))
                    return DisableCommand(ref prgCmds[0]);
            }
            else if (pguidCmdGroup == VsMenus.guidStandardCommandSet2K)
            {
                if (Cmd2kExclude.Contains(prgCmds[0].cmdID))
                    return DisableCommand(ref prgCmds[0]);
            }
            else if (CmdGroupExclude.Contains(pguidCmdGroup))
                return DisableCommand(ref prgCmds[0]);

            return base.QueryStatusCommand(itemid, ref pguidCmdGroup, cCmds, prgCmds, pCmdText);
        }

        #region Helper Methods

        // hide a manu command
        protected int DisableCommand(ref OLECMD command)
        {
            command.cmdf = (uint)OLECMDF.OLECMDF_SUPPORTED |
                (uint)OLECMDF.OLECMDF_INVISIBLE;

            return VSConstants.S_OK;
        }

        // excludes unused property pages
        private string ExcludePropertyPages(string pageIdList)
        {
            if (pageIdList.IndexOf("5E9A8AC2-4F34-4521-858F-4C248BA31532", StringComparison.OrdinalIgnoreCase) != -1)
            {
                // these are the main C# pages
                // they are filtered to "Application" and "Build Events" tabs
                return "{5E9A8AC2-4F34-4521-858F-4C248BA31532};{1E78F8DB-6C07-4D61-A18F-7514010ABD56}";
            }
            else if (pageIdList.IndexOf("A54AD834-9219-4AA6-B589-607AF21C3E26", StringComparison.OrdinalIgnoreCase) != -1)
            {
                // configuration based property pages
                // they are filtered to only "Build" tab
                return "{A54AD834-9219-4AA6-B589-607AF21C3E26}";
            }
            else return ";";
        }

        #endregion
    }
}
