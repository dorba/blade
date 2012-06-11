//----------------------------------------------
// Created from DOM Level 3 Events specification
// See: http://www.w3.org/TR/DOM-Level-3-Events/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Defines the service contract for any object that will handle events.
    /// </summary>
    public interface EventListener
    {
        /// <summary>
        /// Receives the event notifications.
        /// </summary>
        /// <param name="evt">The event object.</param>
        void handleEvent(Event evt);
    }
}