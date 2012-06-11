//----------------------------------------------
// Supported browser objects.
//----------------------------------------------
using System;
using System.Browser;

/// <summary>
/// Represents the browser's location object.
/// </summary>
public sealed class location : Location
{
    internal location() { }

    /// <summary>
    /// Gets or sets the URL hash value.
    /// </summary>
    [ScriptField]
    public static string hash { get; set; }

    /// <summary>
    /// Gets the hostname and port of the URL.
    /// </summary>
    [ScriptField]
    public static string host { get; private set; }

    /// <summary>
    /// Gets the hostname of the URL.
    /// </summary>
    [ScriptField]
    public static string hostname { get; private set; }

    /// <summary>
    /// Gets or sets the entire URL.
    /// </summary>
    [ScriptField]
    public static string href { get; set; }

    /// <summary>
    /// Gets or sets the root relative path or the URL.
    /// </summary>
    [ScriptField]
    public static string pathname { get; set; }

    /// <summary>
    /// Gets or sets the port of the URL.
    /// </summary>
    [ScriptField]
    public static string port { get; set; }

    /// <summary>
    /// Gets the protocol of the URL.
    /// </summary>
    [ScriptField]
    public static string protocol { get; private set; }

    /// <summary>
    /// Gets or sets the query string of the URL.
    /// </summary>
    [ScriptField]
    public static string search { get; set; }

    /// <summary>
    /// Reloads the current document.
    /// </summary>
    public static void reload() { }

    /// <summary>
    /// Reloads the current document.
    /// </summary>
    /// <param name="force">True to force reload from the server.</param>
    public static void reload(bool force) { }

    /// <summary>
    /// Replaces the current document with a new one.
    /// </summary>
    /// <param name="url">The document URL.</param>
    public static void replace(string url) { }

    /// <summary>
    /// Load the document at the provided URL.
    /// </summary>
    /// <param name="url">The document URL.</param>
    public static void assign(string url) { }

    #region Explicit Interface Implementation
    string Location.hash { get; set; }
    string Location.host { get { return null; } }
    string Location.hostname { get { return null; } }
    string Location.href { get; set; }
    string Location.pathname { get; set; }
    string Location.port { get; set; }
    string Location.protocol { get { return null; } }
    string Location.search { get; set; }
    void Location.reload() { }
    void Location.reload(bool force) { }
    void Location.replace(string url) { }
    void Location.assign(string url) { }
    #endregion
}
