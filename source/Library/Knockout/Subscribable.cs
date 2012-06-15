using System;
using System.Html;

namespace Knockout
{
    /// <summary>
    /// Represents a subscribable object.
    /// </summary>
    public sealed class Subscribable<T>
    {
        private Subscribable() { }

        /// <summary>
        /// Subscribes to an event.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="callback">The callback to invoke.</param>
        /// <param name="callbackTarget">An optional callback target to bind to.</param>
        /// <param name="eventName">The event name, or null to use the default event.</param>
        public void subscribe(Action<T> callback, object callbackTarget = null, string eventName = null)
        {
        }

        /// <summary>
        /// Notifies all subscribers of an event.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="value">The value to notify with.</param>
        /// <param name="eventName">The event name, or null to use the default event.</param>
        public void notifySubscribers(T value, string eventName = null)
        {
        }

        /// <summary>
        /// Gets the number of subscribers.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <returns>An integer value.</returns>
        public int getSubscriptionsCount()
        {
            return 0;
        }

        /// <summary>
        /// Applies an extender to the observable.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="extenders">A collection of key value pairs representing the extenders to apply.</param>
        public void extend(object extenders)
        {
        }
    }
}
