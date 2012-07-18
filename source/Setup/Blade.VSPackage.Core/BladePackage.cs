using System;
using System.Runtime.InteropServices;
using Blade.VisualStudio.Common;
using Blade.VisualStudio.Projects;
using Microsoft.VisualStudio.Shell;

namespace Blade.VisualStudio
{
    /// <summary>
    /// The Blade package implementation.
    /// </summary>
    [Guid(LocalConstants.VSPackageId)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)]
    
    // provide class library project type
    [ProvideProjectFactory(
        typeof(BladeClassLibraryProjectFactory),
        LocalConstants.CSharpLanguageName,
        null, null, null,
        LocalConstants.ProjectTemplatesDir,
        LanguageVsTemplate = LocalConstants.CSharpLanguageId,
        DisplayProjectTypeVsTemplate = LocalConstants.CSharpLanguageName)]

    // provide unit test project type
    [ProvideProjectFactory(
        typeof(BladeUnitTestProjectFactory),
        LocalConstants.CSharpLanguageName,
        null, null, null,
        LocalConstants.ProjectTemplatesDir,
        LanguageVsTemplate = LocalConstants.CSharpLanguageId,
        DisplayProjectTypeVsTemplate = LocalConstants.CSharpLanguageName)]
    public sealed class BladePackage : Package
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public BladePackage()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();

            // register blade project subtypes
            RegisterProjectFactory(new BladeClassLibraryProjectFactory(this));
            RegisterProjectFactory(new BladeUnitTestProjectFactory(this));
        }
    }
}
