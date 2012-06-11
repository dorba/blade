//----------------------------------------------
// Supported browser objects.
//----------------------------------------------
using System;
using System.Browser;

/// <summary>
/// Represents the browser's navigator object.
/// </summary>
public sealed class navigator : Navigator
{
    internal navigator() { }

    /// <summary>
    /// Gets the name of the browser.
    /// </summary>
    [ScriptField]
    public static string appName { get; private set; }

    /// <summary>
    /// Gets the browser version information.
    /// </summary>
    [ScriptField]
    public static string appVersion { get; private set; }

    /// <summary>
    /// Gets a value indicating whether or not cookies are enabled.
    /// </summary>
    [ScriptField]
    public static bool cookieEnabled { get; private set; }

    /// <summary>
    /// Gets the current browser language.
    /// </summary>
    [ScriptField]
    public static string language { get; private set; }

    /// <summary>
    /// Gets the name of the platform the browser is running on.
    /// </summary>
    [ScriptField]
    public static string platform { get; private set; }

    /// <summary>
    /// Gets the user agent text.
    /// </summary>
    [ScriptField]
    public static string userAgent { get; private set; }

    #region Explicit Interface Implementation
    string Navigator.appName { get { return null; } }
    string Navigator.appVersion { get { return null; } }
    bool Navigator.cookieEnabled { get { return false; } }
    string Navigator.language { get { return null; } }
    string Navigator.platform { get { return null; } }
    string Navigator.userAgent { get { return null; } }
    #endregion
}