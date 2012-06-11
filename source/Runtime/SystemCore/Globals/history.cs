//----------------------------------------------
// Supported browser objects.
//----------------------------------------------
using System;
using System.Browser;

/// <summary>
/// Represents the browser's history object.
/// </summary>
public sealed class history : History
{
    internal history() { }

    /// <summary>
    /// Gets the number of items in the history.
    /// </summary>
    [ScriptField]
    public static int length { get; private set; }

    /// <summary>
    /// Gets or sets the current history state.
    /// </summary>
    [ScriptField]
    public static object state { get; private set; }

    /// <summary>
    /// Loads the previous document in the history.
    /// </summary>
    public static void back() { }

    /// <summary>
    /// Loads the next document in the history.
    /// </summary>
    public static void forward() { }

    /// <summary>
    /// Loads a document from history, relative to the current offset.
    /// </summary>
    /// <param name="delta">The history offset.</param>
    public static void go(int delta) { }

    /// <summary>
    /// Pushes a new item onto the history stack.
    /// </summary>
    /// <param name="state">The state data.</param>
    /// <param name="title">The title text.</param>
    public static void pushState(object state, string title) { }

    /// <summary>
    /// Pushes a new item onto the history stack.
    /// </summary>
    /// <param name="state">The state data.</param>
    /// <param name="title">The title text.</param>
    /// <param name="url">The URL.</param>
    public static void pushState(object state, string title, string url) { }

    /// <summary>
    /// Replaces the current item on the history stack.
    /// </summary>
    /// <param name="state">The state data.</param>
    /// <param name="title">The title text.</param>
    public static void replaceState(object state, string title) { }

    /// <summary>
    /// Replaces the current item on the history stack.
    /// </summary>
    /// <param name="state">The state data.</param>
    /// <param name="title">The title text.</param>
    /// <param name="url">The URL.</param>
    public static void replaceState(object state, string title, string url) { }

    #region Explicit Interface Implementation
    int History.length { get { return 0; } }
    object History.state { get { return null; } }
    void History.back() { }
    void History.forward() { }
    void History.go(int delta) { }
    void History.pushState(object state, string title) { }
    void History.pushState(object state, string title, string url) { }
    void History.replaceState(object state, string title) { }
    void History.replaceState(object state, string title, string url) { }
    #endregion
}