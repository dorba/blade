//----------------------------------------------
// Created from DOM Level 3 Events specification
// See: http://www.w3.org/TR/DOM-Level-3-Events/
//----------------------------------------------
using System.Browser;

namespace System.Dom
{
    /// <summary>
    /// The method signature for mouse event handlers.
    /// </summary>
    /// <param name="e">The mouse event.</param>
    public delegate void MouseEventHandler(MouseEvent e);

    /// <summary>
    /// Represents an event that is created by a mouse action.
    /// </summary>
    public sealed partial class MouseEvent : UIEvent
    {
        internal MouseEvent() { }

        /// <summary>
        /// Gets the vertical screen coordinate where the event occurred.
        /// </summary>
        [ScriptField]
        public int screenX { get; private set; }

        /// <summary>
        /// Gets the horizontal screen coordinate where the event occurred.
        /// </summary>
        [ScriptField]
        public int screenY { get; private set; }

        /// <summary>
        /// Gets the vertical client coordinate where the event occurred.
        /// </summary>
        [ScriptField]
        public int clientX { get; private set; }

        /// <summary>
        /// Gets the horizontal client coordinate where the event occurred.
        /// </summary>
        [ScriptField]
        public int clientY { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the Ctrl key was pressed when the event occurred.
        /// </summary>
        [ScriptField]
        public bool ctrlKey { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the Shift key was pressed when the event occurred.
        /// </summary>
        [ScriptField]
        public bool shiftKey { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the Alt key was pressed when the event occurred.
        /// </summary>
        [ScriptField]
        public bool altKey { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the meta key was pressed when the event occurred.
        /// </summary>
        [ScriptField]
        public bool metaKey { get; private set; }

        /// <summary>
        /// Gets a value indicating the mouse button that caused the event to occur.
        /// </summary>
        [ScriptField]
        public int button { get; private set; }

        /// <summary>
        /// Gets a secondary target related to the event.
        /// </summary>
        [ScriptField]
        public EventTarget relatedTarget { get; private set; }

        /// <summary>
        /// Initializes the value of a mouse event.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="canBubble">Whether or not the event can bubble.</param>
        /// <param name="canCancel">Whether or not the event can be cancelled.</param>
        /// <param name="view">The associated view.</param>
        /// <param name="detail">The event details.</param>
        /// <param name="screenX">The vertical screen coordinate.</param>
        /// <param name="screenY">The horizontal screen coordinate.</param>
        /// <param name="clientX">The vertical client coordinate.</param>
        /// <param name="clientY">The horizontal client coordinate.</param>
        /// <param name="ctrlKey">Whether the Ctrl key is pressed.</param>
        /// <param name="altKey">Whether the Alt key is pressed.</param>
        /// <param name="shiftKey">Whether the Shift key is pressed.</param>
        /// <param name="metaKey">Whther the meta key is pressed.</param>
        /// <param name="button">The associated mouse button.</param>
        /// <param name="relatedTarget">The secondary target.</param>
        public void initMouseEvent(string type, bool canBubble, bool canCancel,
            Window view, int detail, int screenX, int screenY, int clientX, int clientY,
            bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, int button, EventTarget relatedTarget) { }
    }
}