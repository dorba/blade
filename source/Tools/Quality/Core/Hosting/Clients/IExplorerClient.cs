using System;
using System.IO;

namespace Blade.Tools.Quality.Hosting.Clients
{
    /// <summary>
    /// Represents the internet explorer browser.
    /// </summary>
    internal class IExplorerClient : BrowserClient
    {
        /// <summary>
        /// Gets the name of the browser.
        /// </summary>
        public override string Name
        {
            get { return "IE"; }
        }

        /// <summary>
        /// Gets the startup arguments.
        /// </summary>
        public override string Arguments
        {
            get { return ""; }
        }

        /// <summary>
        /// Gets the name of the executable.
        /// </summary>
        public override string ExeName
        {
            get { return "IEXPLORE.EXE"; }
        }

        /// <summary>
        /// Gets the default install path.
        /// </summary>
        public override string DefaultPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.ProgramFilesX86),
                    @"Internet Explorer\iexplore.exe"); ;
            }
        }
    }
}
