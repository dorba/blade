//----------------------------------------------
// Created from DOM Level 3 Events specification
// See: http://www.w3.org/TR/DOM-Level-3-Events/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Defines the service contract for any object which may produce events.
    /// </summary>
    public interface EventTarget
    {
        /// <summary>
        /// Registers an event listener with the target.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="listener">The listener to register.</param>
        /// <param name="useCapture">Whether or not to use capture.</param>
        void addEventListener(string type, EventListener listener, bool useCapture);

        /// <summary>
        /// Removes an event listener from a target.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="listener">The listener to remove.</param>
        /// <param name="useCapture">Whether or not capture was used.</param>
        void removeEventListener(string type, EventListener listener, bool useCapture);

        /// <summary>
        /// Dispatches an event through the taret.
        /// </summary>
        /// <param name="evt">The event object.</param>
        /// <returns>True if the event completes, false otherwise.</returns>
        bool dispatchEvent(Event evt);
    }
}