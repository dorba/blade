using System;
using System.Reflection;

/// <summary>
/// Array methods are provided as extension methods so that we can
/// apply strongly typed signatures to typed arrays.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
[ScriptName("Array")]
public static class ArrayExtensions
{
    /// <summary>
    /// Creates a new array composed of this array joined with other arrays and/or values.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="items">The values to join with.</param>
    /// <returns>The newly created array.</returns>
    [ScriptMixin]
    public static T[] concat<T>(this T[] array, params T[] items) { return null; }

    /// <summary>
    /// Joins all elements of an array into a string.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <returns>The resulting string.</returns>
    [ScriptMixin]
    public static string join<T>(this T[] array) { return null; }

    /// <summary>
    /// Joins all elements of an array into a string.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="separator">A separator to use between each item.</param>
    /// <returns>The resulting string.</returns>
    [ScriptMixin]
    public static string join<T>(this T[] array, string separator) { return null; }

    /// <summary>
    /// Removes the last element from an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <returns>The removed element.</returns>
    [ScriptMixin]
    public static T pop<T>(this T[] array) { return default(T); }

    /// <summary>
    /// Adds one or more elements to the end of an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="items">The items to add.</param>
    /// <returns>The new length of the array.</returns>
    [ScriptMixin]
    public static int push<T>(this T[] array, params T[] items) { return 0; }

    /// <summary>
    /// Reverses the order of items in the array, in place.
    /// </summary>
    /// <param name="array">The array context.</param>
    [ScriptMixin]
    public static void reverse<T>(this T[] array) { }

    /// <summary>
    /// Removes the first element from an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <returns>The removed element.</returns>
    [ScriptMixin]
    public static T shift<T>(this T[] array) { return default(T); }

    /// <summary>
    /// Extracts a section of an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="startIndex">The index to begin at.</param>
    /// <returns>A new array containing the extracted elements.</returns>
    [ScriptMixin]
    public static T[] slice<T>(this T[] array, int startIndex) { return null; }

    /// <summary>
    /// Extracts a section of an array
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="startIndex">The index to begin at.</param>
    /// <param name="endIndex">The index to stop at.</param>
    /// <returns>A new array containing the extracted elements.</returns>
    [ScriptMixin]
    public static T[] slice<T>(this T[] array, int startIndex, int endIndex) { return null; }

    /// <summary>
    /// Sorts the elements of an array using the default sorting routine.
    /// </summary>
    /// <param name="array">The array context.</param>
    [ScriptMixin]
    public static void sort<T>(this T[] array) { }

    /// <summary>
    /// Sorts the elements of an array using a custom sort function.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="sortFunc">The sort function.</param>
    [ScriptMixin]
    public static void sort<T>(this T[] array, Func<int, T, T> sortFunc) { }

    /// <summary>
    /// Removes a section of an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="startIndex">The index to begin at.</param>
    /// <returns>The removed elements.</returns>
    [ScriptMixin]
    public static T[] splice<T>(this T[] array, int startIndex) { return null; }

    /// <summary>
    /// Removes a section of an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="startIndex">The index to begin at.</param>
    /// <param name="count">The number of items to remove.</param>
    /// <returns>The removed elements.</returns>
    [ScriptMixin]
    public static T[] splice<T>(this T[] array, int startIndex, int count) { return null; }

    /// <summary>
    /// Removes a section of an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="startIndex">The index to begin at.</param>
    /// <param name="count">The number of items to remove.</param>
    /// <param name="items">A set of items to add to the end of the array.</param>
    /// <returns>The removed elements.</returns>
    [ScriptMixin]
    public static T[] splice<T>(this T[] array, int startIndex, int count, params T[] items) { return null; }

    /// <summary>
    /// Inserts one or more elements to the beginning of an array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="items">The items to add.</param>
    /// <returns>The new length of the array.</returns>
    [ScriptMixin]
    public static int unshift<T>(this T[] array, params T[] items) { return 0; }

    /// <summary>
    /// Gets the index of the first matching element in the array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="value">The value to search for.</param>
    /// <returns>The item index, or -1 if one is not found.</returns>
    [ScriptMixin]
    public static int indexOf<T>(this T[] array, T value) { return 0; }

    /// <summary>
    /// Gets the index of the first matching element in the array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="value">The value to search for.</param>
    /// <param name="startIndex">The index to begin searching at.</param>
    /// <returns>The item index, or -1 if one is not found.</returns>
    [ScriptMixin]
    public static int indexOf<T>(this T[] array, T value, int startIndex) { return 0; }

    /// <summary>
    /// Gets the index of the last matching element in the array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="value">The value to search for.</param>
    /// <returns>The item index, or -1 if one is not found.</returns>
    [ScriptMixin]
    public static int lastIndexOf<T>(this T[] array, T value) { return 0; }

    /// <summary>
    /// Gets the index of the last matching element in the array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="value">The value to search for.</param>
    /// <param name="startIndex">The index to begin searching at.</param>
    /// <returns>The item index, or -1 if one is not found.</returns>
    [ScriptMixin]
    public static int lastIndexOf<T>(this T[] array, T value, int startIndex) { return 0; }

    /// <summary>
    /// Creates a new array with all of the elements of this array for which the provided filtering function returns true.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The callback filtering function.</param>
    /// <param name="thisObj">The object to use as this context.</param>
    /// <returns>The newly created array.</returns>
    [ScriptMixin]
    public static T[] filter<T>(this T[] array, Func<T, int, T[], bool> callback, object thisObj = null) { return null; }

    /// <summary>
    /// Calls a function for each element in the array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The callback function.</param>
    /// <param name="thisObj">The object to use as this context.</param>
    [ScriptMixin]
    public static void forEach<T>(this T[] array, Action<T, int> callback, object thisObj = null) { }

    /// <summary>
    /// Calls a function for each element in the array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The callback function.</param>
    /// <param name="thisObj">The object to use as this context.</param>
    [ScriptMixin]
    public static void forEach<T>(this T[] array, Action<T, int, T[]> callback, object thisObj = null) { }

    /// <summary>
    /// Returns true if every element in this array satisfies the provided testing function.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The testing callback function.</param>
    /// <param name="thisObj">The object to use as this context.</param>
    /// <returns>True if all callback invocations return true, false otherwise.</returns>
    [ScriptMixin]
    public static bool every<T>(this T[] array, Func<T, int, T[], bool> callback, object thisObj = null) { return false; }

    /// <summary>
    /// Creates a new array with the results of calling a provided function on every element in this array.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The mapping callback function.</param>
    /// <param name="thisObj">The object to use as this context.</param>
    /// <returns>The newly created array.</returns>
    [ScriptMixin]
    public static T[] map<T, TOut>(this T[] array, Func<T, int, T[], TOut> callback, object thisObj = null) { return null; }

    /// <summary>
    /// Returns true if at least one element in this array satisfies the provided testing function.
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The testing callback function.</param>
    /// <param name="thisObj">The object to use as this context.</param>
    /// <returns>True if any callback invocation returns true, false otherwise.</returns>
    [ScriptMixin]
    public static bool some<T>(this T[] array, Func<T, int, T[], bool> callback, object thisObj = null) { return false; }

    /// <summary>
    /// Applies a function simultaneously against two values of the array, from left to right, to reduce it to a single value
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The reduction callback function.</param>
    /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
    /// <returns>The resulting object.</returns>
    [ScriptMixin]
    public static object reduce<T>(this T[] array, Func<object, T, int, T[], object> callback, object initialValue = null) { return null; }

    /// <summary>
    /// Applies a function simultaneously against two values of the array, from right to left, to reduce it to a single value
    /// </summary>
    /// <param name="array">The array context.</param>
    /// <param name="callback">The reduction callback function.</param>
    /// <param name="initialValue">The object used as the first argument in the first reduction call.</param>
    /// <returns>The resulting object.</returns>
    [ScriptMixin]
    public static object reduceRight<T>(this T[] array, Func<object, T, int, T[], object> callback, object initialValue = null) { return null; }
}