//----------------------------------------------
// Created from DOM Level 3 Events specification
// See: http://www.w3.org/TR/DOM-Level-3-Events/
//----------------------------------------------
using System.Browser;

namespace System.Dom
{
    /// <summary>
    /// Represents an event created from a UI action.
    /// </summary>
    public abstract class UIEvent : Event
    {
        internal UIEvent() { }

        /// <summary>
        /// Gets the view from which the event was generated.
        /// </summary>
        [ScriptField]
        public Window view { get; private set; }

        /// <summary>
        /// Gets details about the event, which may vary depending on type.
        /// </summary>
        [ScriptField]
        public int detail { get; private set; }

        /// <summary>
        /// Initializes the value of a UI event.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="canBubble">Whether or not the event can bubble.</param>
        /// <param name="canCancel">Whether or not the event can be cancelled.</param>
        /// <param name="view">The associated view.</param>
        /// <param name="detail">The event details.</param>
        public void initUIEvent(string type, bool canBubble, bool canCancel, Window view, int detail) { }
    }
}