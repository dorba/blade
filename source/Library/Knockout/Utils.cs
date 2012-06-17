using System;
using System.Html;
using System.Dom;

namespace Knockout
{
    /// <summary>
    /// Provides access to knockout utility functions.
    /// </summary>
    public sealed class Utils
    {
        private Utils() { }

        /// <summary>
        /// Executes an action for each item in an array.
        /// </summary>
        /// <param name="array">The array to operate against.</param>
        /// <param name="action">The action to execute.</param>
        public void arrayForEach(Array array, Action<object> action)
        {
        }

        /// <summary>
        /// Gets the first index of an item in an array.
        /// </summary>
        /// <param name="array">The array to search in.</param>
        /// <param name="item">The item to search for.</param>
        /// <returns>The index of the item, or -1 if one is not found.</returns>
        public int arrayIndexOf(Array array, object item)
        {
            return 0;
        }

        /// <summary>
        /// Gets the first matching element in an array.
        /// </summary>
        /// <param name="array">The array to search in.</param>
        /// <param name="predicate">The predicate to match with.</param>
        /// <param name="predicateOwner">The owning context of the predicate.</param>
        /// <returns>The matching element, or null if one is not found.</returns>
        public object arrayFirst(Array array, Func<object, bool> predicate, object predicateOwner)
        {
            return null;
        }

        /// <summary>
        /// Removes an item from an array.
        /// </summary>
        /// <param name="array">The array to remove from.</param>
        /// <param name="itemToRemove">The item to remove.</param>
        public void arrayRemoveItem(Array array, object itemToRemove)
        {
        }

        /// <summary>
        /// Creates a new array containing only the distinct values of the original array.
        /// </summary>
        /// <param name="array">The original array.</param>
        /// <returns>The newly created array.</returns>
        public Array arrayGetDistinctValues(Array array)
        {
            return null;
        }

        /// <summary>
        /// Creates a new array containing mapped values from each value in the original array.
        /// </summary>
        /// <param name="array">The original array.</param>
        /// <param name="mapping">The mapping function.</param>
        /// <returns>The newly created array.</returns>
        public Array arrayMap(Array array, Func<object, object> mapping)
        {
            return null;
        }

        /// <summary>
        /// Creates a new array containing a subset of filtered values from the original array.
        /// </summary>
        /// <param name="array">The original array.</param>
        /// <param name="predicate">The filtering function.</param>
        /// <returns>The newly created array.</returns>
        public Array arrayFilter(Array array, Func<object, bool> predicate)
        {
            return null;
        }

        /// <summary>
        /// Adds all values from one or more arrays into an existing array.
        /// </summary>
        /// <param name="array">The array to add to.</param>
        /// <param name="valuesToPush">The arrays to add.</param>
        /// <returns>The input array, with all added values.</returns>
        public Array arrayPushAll(Array array, Array[] valuesToPush)
        {
            return null;
        }

        /// <summary>
        /// Copies all properties of source into the target.
        /// </summary>
        /// <param name="target">The extension target.</param>
        /// <param name="source">The extension source.</param>
        /// <returns>The input object, with extended properties.</returns>
        public object extend(object target, object source)
        {
            return null;
        }

        /// <summary>
        /// Gets all fields with a form by name.
        /// </summary>
        /// <param name="form">The form element.</param>
        /// <param name="fieldName">The field name.</param>
        /// <returns>An array of matching fields.</returns>
        public HTMLElement[] getFormFields(HTMLElement form, string fieldName)
        {
            return null;
        }

        /// <summary>
        /// Posts data to the specific URL.
        /// </summary>
        /// <param name="url">The URL to post to.</param>
        /// <param name="data">The data to post.</param>
        /// <param name="options">The post options.</param>
        public void postJson(string url, object data, object options)
        {
        }

        /// <summary>
        /// Posts data from a from, using the form's action URL.
        /// </summary>
        /// <param name="form">The form post.</param>
        /// <param name="data">The data to post.</param>
        /// <param name="options">The post options.</param>
        public void postJson(HTMLElement form, object data, object options)
        {
        }

        /// <summary>
        /// Parses a JSON string.
        /// </summary>
        /// <param name="jsonString">The string to parse.</param>
        /// <returns>The resulting object.</returns>
        public object parseJson(string jsonString)
        {
            return null;
        }

        /// <summary>
        /// Converts an object into a JSON string.
        /// </summary>
        /// <param name="data">The object to convert.</param>
        /// <param name="replacer">The optional replacment function.</param>
        /// <param name="space">The optional spacing string.</param>
        /// <returns></returns>
        public string stringifyJson(object data, Func<string, object, object> replacer = null, string space = null)
        {
            return null;
        }

        /// <summary>
        /// Registers an event handler with an element.
        /// </summary>
        /// <param name="element">The target element.</param>
        /// <param name="eventType">The event type name.</param>
        /// <param name="handler">The event handler function.</param>
        public void registerEventHandler(HTMLElement element, string eventType, EventHandler handler)
        {
        }

        /// <summary>
        /// Creates an integer array from the min to max, inclusive.
        /// </summary>
        /// <param name="min">The range starting value.</param>
        /// <param name="max">The range ending value.</param>
        /// <returns>The newly created array.</returns>
        public int[] range(int min, int max)
        {
            return null;
        }

        /// <summary>
        /// Creates an integer array from the min to max, inclusive.
        /// </summary>
        /// <param name="min">The range starting observable value.</param>
        /// <param name="max">The range ending observable value.</param>
        /// <returns>The newly created array.</returns>
        public int[] range(Observable<int> min, Observable<int> max)
        {
            return null;
        }

        /// <summary>
        /// Toggles a CSS class name on an HTML element.
        /// </summary>
        /// <param name="node">The element to toggle on.</param>
        /// <param name="classNames">The class name to toggle.</param>
        /// <param name="shouldHaveClass">True if the element should have the class, false otherwise.</param>
        public void toggleDomNodeCssClass(HTMLElement node, string classNames, bool shouldHaveClass)
        {
        }

        /// <summary>
        /// Triggers the specific event on an HTML element.
        /// </summary>
        /// <param name="element">The element to trigger on.</param>
        /// <param name="eventType">The name of the event to trigger.</param>
        public void triggerEvent(HTMLElement element, string eventType)
        {
        }

        /// <summary>
        /// Ensures that an object is unwrapped.
        /// </summary>
        /// <typeparam name="T">The expected type.</typeparam>
        /// <param name="value">The observable candidate.</param>
        /// <returns>The resulting value.</returns>
        public T unwrapObservable<T>(object value)
        {
            return default(T);
        }
    }
}
