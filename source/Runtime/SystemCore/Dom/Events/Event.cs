//----------------------------------------------
// Created from DOM Level 3 Events specification
// See: http://www.w3.org/TR/DOM-Level-3-Events/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// The method signature for event handlers.
    /// </summary>
    /// <param name="e">The event.</param>
    public delegate void EventHandler(Event e);

    /// <summary>
    /// An object used to pass information about an event to event handler.
    /// </summary>
    public abstract class Event
    {
        internal Event() { }

        /// <summary>
        /// Represents the capturing phase of an event.
        /// </summary>
        public const int CAPTURING_PHASE = 1;

        /// <summary>
        /// Represents the target evaluation phase of an event.
        /// </summary>
        public const int AT_TARGET = 2;

        /// <summary>
        /// Represents the bubbling phase of an event.
        /// </summary>
        public const int BUBBLING_PHASE = 3;

        /// <summary>
        /// Gets the type name of the event.
        /// </summary>
        [ScriptField]
        public string type { get; private set; }

        /// <summary>
        /// Gets the target which originated the event.
        /// </summary>
        [ScriptField]
        public EventTarget target { get; private set; }

        /// <summary>
        /// Gets the target which is currently being processed.
        /// </summary>
        [ScriptField]
        public EventTarget currentTarget { get; private set; }

        /// <summary>
        /// Gets the current event phase.
        /// </summary>
        [ScriptField]
        public int eventPhase { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the event bubbles.
        /// </summary>
        [ScriptField]
        public bool bubbles { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the event can be cancelled.
        /// </summary>
        [ScriptField]
        public bool cancelable { get; private set; }

        /// <summary>
        /// Get the date and time when the event was created.
        /// </summary>
        [ScriptField]
        public int timeStamp { get; private set; }

        /// <summary>
        /// Gets a value indicating whether or not the default action has been prevented.
        /// </summary>
        [ScriptField]
        public bool defaultPrevented { get; private set; }

        /// <summary>
        /// Stops further propagation of an event.
        /// </summary>
        public void stopPropagation() { }

        /// <summary>
        /// Immediately stops further propagation of an event.
        /// </summary>
        public void stopImmediatePropagation() { }

        /// <summary>
        /// Cancels the event, causing the default action of the event not to occur.
        /// </summary>
        public void preventDefault() { }

        /// <summary>
        /// Initializes the value of an event.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="canBubble">Whether or not the event can bubble.</param>
        /// <param name="canCancel">Whether or not the event can be cancelled.</param>
        public void initEvent(string type, bool canBubble, bool canCancel) { }
    }
}