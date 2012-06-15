using System;
using System.Html;

namespace Knockout
{
    /// <summary>
    /// Represents an observable array object.
    /// </summary>
    /// <typeparam name="T">The underlying data type.</typeparam>
    /// <param name="value">An optional parameter used to set the underlying array.</param>
    /// <returns>The current underlying array.</returns>
    public delegate T[] ObservableArray<T>(T[] value = null);

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
        public static void subscribe<T>(this ObservableArray<T> observable, Action<T> callback, object callbackTarget = null, string eventName = null)
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
        public static void notifySubscribers<T>(this ObservableArray<T> observable, T value, string eventName = null)
        {
        }

        /// <summary>
        /// Gets the number of subscribers.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <returns>An integer value.</returns>
        [ScriptMixin]
        public static int getSubscriptionsCount<T>(this ObservableArray<T> observable)
        {
            return 0;
        }

        /// <summary>
        /// Notifies subscribers that the value has changed.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="observable">The observable.</param>
        [ScriptMixin]
        public static void valueHasMutated<T>(this ObservableArray<T> observable)
        {
        }

        /// <summary>
        /// Notifies subscribers that the value is preparing to be changed.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="observable">The observable.</param>
        [ScriptMixin]
        public static void valueWillMutate<T>(this ObservableArray<T> observable)
        {
        }

        /// <summary>
        /// Applies an extender to the observable.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="extenders">A collection of key value pairs representing the extenders to apply.</param>
        [ScriptMixin]
        public static void extend<T>(this ObservableArray<T> observable, object extenders)
        {
        }

        /// <summary>
        /// Removes all occurrences of a specific value from the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="value">The value to remove.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static T[] remove<T>(this ObservableArray<T> observable, T value)
        {
            return null;
        }

        /// <summary>
        /// Removes items from the array using a predicate function.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static T[] remove<T>(this ObservableArray<T> observable, Func<T, bool> predicate)
        {
            return null;
        }

        /// <summary>
        /// Removes all entries from the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static T[] removeAll<T>(this ObservableArray<T> observable)
        {
            return null;
        }

        /// <summary>
        /// Removes all occurrences of a set of values from the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="values">The values to remove.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static T[] removeAll<T>(this ObservableArray<T> observable, T[] values)
        {
            return null;
        }

        /// <summary>
        /// Destroys all occurrences of a specific value from the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="value">The value to destroy.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static void destroy<T>(this ObservableArray<T> observable, T value)
        {
        }

        /// <summary>
        /// Destroys items from the array using a predicate function.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static void destroy<T>(this ObservableArray<T> observable, Func<T, bool> predicate)
        {
        }

        /// <summary>
        /// Destroys all entries in the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <returns>The destroyed items.</returns>
        [ScriptMixin]
        public static void destroyAll<T>(this ObservableArray<T> observable)
        {
        }

        /// <summary>
        /// Destroys all occurrences of a set of values from the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="values">The values to destroy.</param>
        /// <returns>The destroyed items.</returns>
        [ScriptMixin]
        public static void destroyAll<T>(this ObservableArray<T> observable, T[] values)
        {
        }

        /// <summary>
        /// Gets the first index of the specified value.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="value">The value to search for.</param>
        /// <returns>The index of the first match, or -1 if not matching elements are found.</returns>
        [ScriptMixin]
        public static int indexOf<T>(this ObservableArray<T> observable, T value)
        {
            return 0;
        }

        /// <summary>
        /// Replaces an item in the array with a new value.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="oldItem">The item to replace.</param>
        /// <param name="newItem">The item to insert.</param>
        [ScriptMixin]
        public static void replace<T>(this ObservableArray<T> observable, T oldItem, T newItem)
        {
        }

        /// <summary>
        /// Removes and returns the last element of the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <returns>The removed item.</returns>
        [ScriptMixin]
        public static T pop<T>(this ObservableArray<T> observable)
        {
            return default(T);
        }

        /// <summary>
        /// Pushes one or more new values onto the end of the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="values">The values to add.</param>
        /// <returns>The new length of the array.</returns>
        [ScriptMixin]
        public static int push<T>(this ObservableArray<T> observable, params T[] values)
        {
            return 0;
        }

        /// <summary>
        /// Reverses the order of items in the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        [ScriptMixin]
        public static void reverse<T>(this ObservableArray<T> observable)
        {
        }

        /// <summary>
        /// Removes and returns the first element of the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <returns>The removed item.</returns>
        [ScriptMixin]
        public static T shift<T>(this ObservableArray<T> observable)
        {
            return default(T);
        }

        /// <summary>
        /// Sorts the array using the default comparer.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        [ScriptMixin]
        public static void sort<T>(this ObservableArray<T> observable)
        {
        }

        /// <summary>
        /// Sorts the array using a custom sort function.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="sortFunc">The function to sort with.</param>
        [ScriptMixin]
        public static void sort<T>(this ObservableArray<T> observable, Func<T, T, int> sortFunc)
        {
        }

        /// <summary>
        /// Removes a section of the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="startIndex">The index to begin removing at.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static T[] splice<T>(this ObservableArray<T> observable, int startIndex)
        {
            return null;
        }

        /// <summary>
        /// Removes a section of the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="startIndex">The index to begin removing at.</param>
        /// <param name="count">The number of items to remove.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static T[] splice<T>(this ObservableArray<T> observable, int startIndex, int count)
        {
            return null;
        }

        /// <summary>
        /// Removes a section of the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="startIndex">The index to begin removing at.</param>
        /// <param name="count">The number of items to remove.</param>
        /// <param name="newItems">A set of new items to append to the end of the array.</param>
        /// <returns>The removed items.</returns>
        [ScriptMixin]
        public static T[] splice<T>(this ObservableArray<T> observable, int startIndex, int count, params T[] newItems)
        {
            return null;
        }

        /// <summary>
        /// Inserts one or more values at the beginning of the array.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="values">The values to insert.</param>
        /// <returns>The new length of the array.</returns>
        [ScriptMixin]
        public static int unshift<T>(this ObservableArray<T> observable, params T[] values)
        {
            return 0;
        }

        /// <summary>
        /// Copies a section of an array, leaving the original array unchanged.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="startIndex">The index to start copying at.</param>
        /// <returns>The copied elements.</returns>
        [ScriptMixin]
        public static T[] slice<T>(this ObservableArray<T> observable, int startIndex)
        {
            return null;
        }

        /// <summary>
        /// Copies a section of an array, leaving the original array unchanged.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <param name="observable">The observable.</param>
        /// <param name="startIndex">The index to start copying at.</param>
        /// <param name="endIndex">The index to copy to.</param>
        /// <returns>The copied elements.</returns>
        [ScriptMixin]
        public static T[] slice<T>(this ObservableArray<T> observable, int startIndex, int endIndex)
        {
            return null;
        }

        // -- candidates for public API --
        // -------------------------------
        // equalityComparer
        // -------------------------------
    }
}
