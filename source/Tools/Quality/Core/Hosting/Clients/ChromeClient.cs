using System;
using System.IO;

namespace Blade.Tools.Quality.Hosting.Clients
{
    /// <summary>
    /// Represents the chrome browser.
    /// </summary>
    internal class ChromeClient : BrowserClient
    {
        /// <summary>
        /// Gets the name of the browser.
        /// </summary>
        public override string Name
        {
            get { return "Chrome"; }
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
            get { return "chrome.exe"; }
        }

        /// <summary>
        /// Gets the default install path.
        /// </summary>
        public override string DefaultPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                    @"Google\Chrome\Application\chrome.exe"); ;
            }
        }
    }
}
