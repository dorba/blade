//----------------------------------------------
// Supported browser objects.
//----------------------------------------------
using System;
using System.Css;

/// <summary>
/// Represent the browser's screen object.
/// </summary>
public sealed class screen : Screen
{
    internal screen() { }

    /// <summary>
    /// Gets the client screen height, in pixels.
    /// </summary>
    [ScriptField]
    public static int height { get; private set; }

    /// <summary>
    /// Gets the client screen width, in pixels.
    /// </summary>
    [ScriptField]
    public static int width { get; private set; }

    /// <summary>
    /// Gets the client pixel depth. 
    /// </summary>
    [ScriptField]
    public static int pixelDepth { get; private set; }

    /// <summary>
    /// Gets the client color depth.
    /// </summary>
    [ScriptField]
    public static int colorDepth { get; private set; }

    /// <summary>
    /// Gets the the client available width, in pixels.
    /// </summary>
    [ScriptField]
    public static int availWidth { get; private set; }

    /// <summary>
    /// Gets the client available height, in pixels.
    /// </summary>
    [ScriptField]
    public static int availHeight { get; private set; }

    #region Explicit Interface Implementation
    int System.Css.Screen.height { get { return 0; } }
    int System.Css.Screen.width { get { return 0; } }
    int System.Css.Screen.pixelDepth { get { return 0; } }
    int System.Css.Screen.colorDepth { get { return 0; } }
    int System.Css.Screen.availWidth { get { return 0; } }
    int System.Css.Screen.availHeight { get { return 0; } }
    #endregion
}