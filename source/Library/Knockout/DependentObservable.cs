using System;
using System.Html;
using System.Reflection;

namespace Knockout
{
    /// <summary>
    /// Represents a dependent observable object.
    /// </summary>
    /// <typeparam name="T">The underlying data type.</typeparam>
    /// <returns>The current underlying value.</returns>
    public delegate T DependentObservable<T>();

    /// <summary>
    /// These class exists to provide portions of the knockout API.
    /// Its methods are not intended to be invoked directly.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// Subscribes to an event.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="callback">The callback to invoke.</param>
        /// <param name="callbackTarget">An optional callback target to bind to.</param>
        /// <param name="eventName">The event name, or null to use the default event.</param>
        [ScriptMixin]
        public static void subscribe<T>(this DependentObservable<T> observable, Action<T> callback, object callbackTarget = null, string eventName = null)
        {
        }

        /// <summary>
        /// Notifies all subscribers of an event.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="value">The value to notify with.</param>
        /// <param name="eventName">The event name, or null to use the default event.</param>
        [ScriptMixin]
        public static void notifySubscribers<T>(this DependentObservable<T> observable, T value, string eventName = null)
        {
        }

        /// <summary>
        /// Gets the number of subscribers.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <returns>An integer value.</returns>
        [ScriptMixin]
        public static int getSubscriptionsCount<T>(this DependentObservable<T> observable)
        {
            return 0;
        }

        /// <summary>
        /// Gets the number of dependencies in the observable.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <returns>The dependency count.</returns>
        [ScriptMixin]
        public static int getDependenciesCount<T>(this DependentObservable<T> observable)
        {
            return 0;
        }

        /// <summary>
        /// Disposes of the object.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="observable">The observable.</param>
        [ScriptMixin]
        public static void dispose<T>(this DependentObservable<T> observable)
        {
        }

        /// <summary>
        /// Applies an extender to the observable.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="extenders">A collection of key value pairs representing the extenders to apply.</param>
        [ScriptMixin]
        public static void extend<T>(this DependentObservable<T> observable, object extenders)
        {
        }
    }
}
