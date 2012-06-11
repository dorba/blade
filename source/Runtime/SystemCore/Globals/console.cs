//----------------------------------------------
// Supported browser objects.
//----------------------------------------------

/// <summary>
/// Represents the browser console object.
/// </summary>
public sealed class console
{
    internal console() { }

	/// <summary>
	/// Clears all data from the console.
	/// </summary>
	public static void clear() { }

    /// <summary>
    /// Writes a log message to the console.
    /// </summary>
    /// <param name="message">The value to write.</param>
    public static void log(object message) { }

    /// <summary>
    /// Writes an informational message to the console.
    /// </summary>
    /// <param name="message">The value to write.</param>
    public static void info(object message) { }

    /// <summary>
    /// Writes a warning message to the console.
    /// </summary>
    /// <param name="message">The value to write.</param>
    public static void warn(object message) { }

    /// <summary>
    /// Writes an error message to the console.
    /// </summary>
    /// <param name="message">The value to write.</param>
    public static void error(object message) { }
}