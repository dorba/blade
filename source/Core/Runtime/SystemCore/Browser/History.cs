//----------------------------------------------
// Supported browser objects.
//----------------------------------------------

namespace System.Browser
{
    /// <summary>
    /// The definition for the browser history object.
    /// </summary>
    public partial interface History
    {
        /// <summary>
        /// Gets the number of items in the history.
        /// </summary>
        [ScriptField]
        int length { get; }

        /// <summary>
        /// Gets or sets the current history state.
        /// </summary>
        [ScriptField]
        object state { get; }

        /// <summary>
        /// Loads the previous document in the history.
        /// </summary>
        void back();

        /// <summary>
        /// Loads the next document in the history.
        /// </summary>
        void forward();

        /// <summary>
        /// Loads a document from history, relative to the current offset.
        /// </summary>
        /// <param name="delta">The history offset.</param>
        void go(int delta);

        /// <summary>
        /// Pushes a new item onto the history stack.
        /// </summary>
        /// <param name="state">The state data.</param>
        /// <param name="title">The title text.</param>
        void pushState(object state, string title);

        /// <summary>
        /// Pushes a new item onto the history stack.
        /// </summary>
        /// <param name="state">The state data.</param>
        /// <param name="title">The title text.</param>
        /// <param name="url">The URL.</param>
        void pushState(object state, string title, string url);

        /// <summary>
        /// Replaces the current item on the history stack.
        /// </summary>
        /// <param name="state">The state data.</param>
        /// <param name="title">The title text.</param>
        void replaceState(object state, string title);

        /// <summary>
        /// Replaces the current item on the history stack.
        /// </summary>
        /// <param name="state">The state data.</param>
        /// <param name="title">The title text.</param>
        /// <param name="url">The URL.</param>
        void replaceState(object state, string title, string url);
    }
}