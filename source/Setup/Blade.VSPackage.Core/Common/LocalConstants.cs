using System;

namespace Blade.VisualStudio.Common
{
    /// <summary>
    /// Constants for internal use.
    /// </summary>
    internal static class LocalConstants
    {
        /// <summary>
        /// The ID for the Blade core package implementation.
        /// </summary>
        public const string VSPackageId = "a154f0aa-1cfb-4dcf-ba83-0bcdc9ebb9b2";

        /// <summary>
        /// The GUID used to identify the standard C# Class Library project.
        /// </summary>
        public static readonly Guid DefaultClassLibraryProjectId = new Guid("FAE04EC0-301F-11D3-BF4B-00C04F79EFBC");

        /// <summary>
        /// The ID for the Blade Class Library project.
        /// </summary>
        public const string ClassLibraryProjectId = "BED6C098-9DBB-49FB-8840-3B9B1EEA05E6";

        /// <summary>
        /// The ID for the Blade Class Library project factory.
        /// </summary>
        public const string ClassLibraryProjectFactoryId = "BE3FC8FB-C7F0-443E-9E6A-AC810000E984";

        /// <summary>
        /// The ID for the Blade Unit Test project.
        /// </summary>
        public const string UnitTestProjectId = "B23C0CEA-F820-44FB-825B-FE205D176257";

        /// <summary>
        /// The ID for the Blade Unit Test project factory.
        /// </summary>
        public const string UnitTestProjectFactoryId = "BF6BC72F-BD32-41BB-AC83-35C9D489F3EE";

        /// <summary>
        /// The Blade C# language ID.
        /// </summary>
        public const string CSharpLanguageId = "BladeCSharp";

        /// <summary>
        /// The Blade C# language display name.
        /// </summary>
        public const string CSharpLanguageName = "Blade C#";

        /// <summary>
        /// The Blade project template relative path.
        /// </summary>
        public const string ProjectTemplatesDir = "..\\Templates\\Projects";
    };
}