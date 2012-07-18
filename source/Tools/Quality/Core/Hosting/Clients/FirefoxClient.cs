using System;
using System.IO;
using Microsoft.Win32;

namespace Blade.Tools.Quality.Hosting.Clients
{
    /// <summary>
    /// Represents the firefox browser.
    /// </summary>
    internal class FirefoxClient : BrowserClient
    {
        /// <summary>
        /// Gets the name of the browser.
        /// </summary>
        public override string Name
        {
            get { return "Firefox"; }
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
            get { return "firefox.exe"; }
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
                    @"Mozilla Firefox\firefox.exe"); ;
            }
        }
    }
}
