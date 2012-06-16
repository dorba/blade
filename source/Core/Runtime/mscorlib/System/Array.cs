using System.Collections;

namespace System
{
    /// <summary>
    /// The System array object.
    /// </summary>
	public sealed class Array : IEnumerable
    {
		/// <summary>
		/// Gets or sets an array item by index.
		/// </summary>
		/// <param name="index">The array index.</param>
		/// <returns>The specified array item.</returns>
		public object this[int index]
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets or sets the array length.
		/// </summary>
		[ScriptField]
		public int length { get; set; }

		/// <summary>
		/// Creates a new instance of an array.
		/// </summary>
		public Array() { }

		/// <summary>
		/// Creates a new array with the specified size.
		/// </summary>
		/// <param name="size">The array size.</param>
		public Array(int size) { }

		/// <summary>
		/// Creates a new array from a set of existing items.
		/// </summary>
		/// <param name="items">The array items.</param>
		public Array(params object[] items) { }

        /// <summary>
        /// Creates a new array composed of this array joined with other arrays and/or values.
        /// </summary>
        /// <param name="items">The values to join with.</param>
        /// <returns>The newly created array.</returns>
		public Array concat(params object[] items) { return null; }

        /// <summary>
        /// Joins all elements of an array into a string.
        /// </summary>
        /// <returns>The resulting string.</returns>
		public string join() { return null; }

        /// <summary>
        /// Joins all elements of an array into a string.
        /// </summary>
        /// <param name="separator">A separator to use between each item.</param>
        /// <returns>The resulting string.</returns>
		public string join(string separator) { return null; }

        /// <summary>
        /// Removes the last element from an array.
        /// </summary>
        /// <returns>The removed element.</returns>
		public object pop() { return null; }

        /// <summary>
        /// Adds one or more elements to the end of an array.
        /// </summary>
        /// <param name="items">The items to add.</param>
        /// <returns>The new length of the array.</returns>
		public int push(params object[] items) { return 0; }

        /// <summary>
        /// Reverses the order of items in the array, in place.
        /// </summary>
		public void reverse() { }

        /// <summary>
        /// Removes the first element from an array.
        /// </summary>
        /// <returns>The removed element.</returns>
		public object shift() { return null; }

        /// <summary>
        /// Extracts a section of an array.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <returns>A new array containing the extracted elements.</returns>
		public Array slice(int startIndex) { return null; }

        /// <summary>
        /// Extracts a section of an array
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <param name="endIndex">The index to stop at.</param>
        /// <returns>A new array containing the extracted elements.</returns>
		public Array slice(int startIndex, int endIndex) { return null; }

        /// <summary>
        /// Sorts the elements of an array using the default sorting routine.
        /// </summary>
		public void sort() { }

        /// <summary>
        /// Sorts the elements of an array using a custom sort function.
        /// </summary>
        /// <param name="sortFunc">The sort function.</param>
		public void sort(Func<int, object, object> sortFunc) { }

        /// <summary>
        /// Removes a section of an array.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <returns>The removed elements.</returns>
		public Array splice(int startIndex) { return null; }

        /// <summary>
        /// Removes a section of an array.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <param name="count">The number of items to remove.</param>
        /// <returns>The removed elements.</returns>
		public Array splice(int startIndex, int count) { return null; }

        /// <summary>
        /// Removes a section of an array.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <param name="count">The number of items to remove.</param>
        /// <param name="items">A set of items to add to the end of the array.</param>
        /// <returns>The removed elements.</returns>
		public Array splice(int startIndex, int count, params object[] items) { return null; }

        /// <summary>
        /// Inserts one or more elements to the beginning of an array.
        /// </summary>
        /// <param name="items">The items to add.</param>
        /// <returns>The new length of the array.</returns>
		public int unshift(params object[] items) { return 0; }

        /// <summary>
        /// Gets the index of the first matching element in the array.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns>The item index, or -1 if one is not found.</returns>
		public int indexOf(object value) { return 0; }

        /// <summary>
        /// Gets the index of the first matching element in the array.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <param name="startIndex">The index to begin searching at.</param>
        /// <returns>The item index, or -1 if one is not found.</returns>
		public int indexOf(object value, int startIndex) { return 0; }

        /// <summary>
        /// Gets the index of the last matching element in the array.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns>The item index, or -1 if one is not found.</returns>
		public int lastIndexOf(object value) { return 0; }

        /// <summary>
        /// Gets the index of the last matching element in the array.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <param name="startIndex">The index to begin searching at.</param>
        /// <returns>The item index, or -1 if one is not found.</returns>
		public int lastIndexOf(object value, int startIndex) { return 0; }

        /// <summary>
        /// Creates a new array with all of the elements of this array for which the provided filtering function returns true.
        /// </summary>
        /// <param name="callback">The callback filtering function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array filter(Func<bool> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Creates a new array with all of the elements of this array for which the provided filtering function returns true.
        /// </summary>
        /// <param name="callback">The callback filtering function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array filter(Func<bool, object> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Creates a new array with all of the elements of this array for which the provided filtering function returns true.
        /// </summary>
        /// <param name="callback">The callback filtering function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array filter(Func<bool, object, int> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Creates a new array with all of the elements of this array for which the provided filtering function returns true.
        /// </summary>
        /// <param name="callback">The callback filtering function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array filter(Func<bool, object, int, Array> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Calls a function for each element in the array.
        /// </summary>
        /// <param name="callback">The callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
		public void forEach(Action<object> callback, object thisObj = null) { }

        /// <summary>
        /// Calls a function for each element in the array.
        /// </summary>
        /// <param name="callback">The callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
		public void forEach(Action<object, int> callback, object thisObj = null) { }

        /// <summary>
        /// Calls a function for each element in the array.
        /// </summary>
        /// <param name="callback">The callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
		public void forEach(Action<object, int, Array> callback, object thisObj = null) { }

        /// <summary>
        /// Returns true if every element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if all callback invocations return true, false otherwise.</returns>
		public bool every(Func<bool> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Returns true if every element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if all callback invocations return true, false otherwise.</returns>
		public bool every(Func<bool, object> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Returns true if every element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if all callback invocations return true, false otherwise.</returns>
		public bool every(Func<bool, object, int> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Returns true if every element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if all callback invocations return true, false otherwise.</returns>
		public bool every(Func<bool, object, int, Array> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Creates a new array with the results of calling a provided function on every element in this array.
        /// </summary>
        /// <param name="callback">The mapping callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array map(Func<object> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Creates a new array with the results of calling a provided function on every element in this array.
        /// </summary>
        /// <param name="callback">The mapping callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array map(Func<object, object> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Creates a new array with the results of calling a provided function on every element in this array.
        /// </summary>
        /// <param name="callback">The mapping callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array map(Func<object, object, int> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Creates a new array with the results of calling a provided function on every element in this array.
        /// </summary>
        /// <param name="callback">The mapping callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>The newly created array.</returns>
		public Array map(Func<object, object, int, Array> callback, object thisObj = null) { return null; }

        /// <summary>
        /// Returns true if at least one element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if any callback invocation returns true, false otherwise.</returns>
		public bool some(Func<bool> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Returns true if at least one element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if any callback invocation returns true, false otherwise.</returns>
		public bool some(Func<bool, object> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Returns true if at least one element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if any callback invocation returns true, false otherwise.</returns>
		public bool some(Func<bool, object, int> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Returns true if at least one element in this array satisfies the provided testing function.
        /// </summary>
        /// <param name="callback">The testing callback function.</param>
        /// <param name="thisObj">The object to use as this context.</param>
        /// <returns>True if any callback invocation returns true, false otherwise.</returns>
		public bool some(Func<bool, object, int, Array> callback, object thisObj = null) { return false; }

        /// <summary>
        /// Applies a function simultaneously against two values of the array, from left to right, to reduce it to a single value
        /// </summary>
        /// <param name="callback">The reduction callback function.</param>
        /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
        /// <returns>The resulting object.</returns>
		public object reduce(Func<object, object, object> callback, object initialValue = null) { return null; }

        /// <summary>
        /// Applies a function simultaneously against two values of the array, from left to right, to reduce it to a single value
        /// </summary>
        /// <param name="callback">The reduction callback function.</param>
        /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
        /// <returns>The resulting object.</returns>
		public object reduce(Func<object, object, object, int> callback, object initialValue = null) { return null; }

        /// <summary>
        /// Applies a function simultaneously against two values of the array, from left to right, to reduce it to a single value
        /// </summary>
        /// <param name="callback">The reduction callback function.</param>
        /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
        /// <returns>The resulting object.</returns>
		public object reduce(Func<object, object, object, int, Array> callback, object initialValue = null) { return null; }

        /// <summary>
        /// Applies a function simultaneously against two values of the array, from right to left, to reduce it to a single value
        /// </summary>
        /// <param name="callback">The reduction callback function.</param>
        /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
        /// <returns>The resulting object.</returns>
		public object reduceRight(Func<object, object, object> callback, object initialValue = null) { return null; }

        /// <summary>
        /// Applies a function simultaneously against two values of the array, from right to left, to reduce it to a single value
        /// </summary>
        /// <param name="callback">The reduction callback function.</param>
        /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
        /// <returns>The resulting object.</returns>
		public object reduceRight(Func<object, object, object, int> callback, object initialValue = null) { return null; }

        /// <summary>
        /// Applies a function simultaneously against two values of the array, from right to left, to reduce it to a single value
        /// </summary>
        /// <param name="callback">The reduction callback function.</param>
        /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
        /// <returns>The resulting object.</returns>
		public object reduceRight(Func<object, object, object, int, Array> callback, object initialValue = null) { return null; }

		/// <summary>
		/// Determines whether or not an object is an array.
		/// </summary>
		/// <param name="obj">The object to check.</param>
		/// <returns>True if the object is a array, false otherwise.</returns>
		public static bool isArray(object obj) { return false; }

        /// <summary>
        /// Gets the array enumerator.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }
}