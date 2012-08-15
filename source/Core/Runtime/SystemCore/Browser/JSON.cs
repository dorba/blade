//
// The information in this file is adapted from the Mozilla documentation: https://developer.mozilla.org/en-US/docs/JavaScript/Reference/Global_Objects/JSON
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Browser
{
    public interface JSON
    {
        /// <summary>
        /// Parse a string as JSON, optionally transform the produced value and its properties, and return the value.
        /// </summary>
        /// <param name="text">Parse a string as JSON, optionally transforming the value produced by parsing.</param>
        /// <returns>An object corresponding to the parsed JSON string.</returns>
        object parse(string text);

        /// <summary>
        /// Parse a string as JSON, optionally transform the produced value and its properties, and return the value.
        /// </summary>
        /// <param name="text">Parse a string as JSON, optionally transforming the value produced by parsing.</param>
        /// <param name="reviver">Prescribes how the value originally produced by parsing is transformed, before being returned.</param>
        /// <returns>An object corresponding to the parsed JSON string.</returns>
        object parse(string text, Action<string, object> reviver);

        /// <summary>
        /// Converts a JavaScript object into a JSON string.
        /// </summary>
        /// <param name="value">The JavaScript object to convert into a JSON string.</param>
        /// <returns>The JSON serialized representation of the object.</returns>
        string stringify(object value);

        /// <summary>
        /// Converts a JavaScript object into a JSON string.
        /// </summary>
        /// <param name="value">The JavaScript object to convert into a JSON string.</param>
        /// <param name="replacer">A function that alters the behavior of the stringification process.</param>
        /// <returns>The JSON serialized representation of the object.</returns>
        string stringify(object value, Func<string, object, object> replacer);

        /// <summary>
        /// Converts a JavaScript object into a JSON string.
        /// </summary>
        /// <param name="value">The JavaScript object to convert into a JSON string.</param>
        /// <param name="replacer">A function that alters the behavior of the stringification process.</param>
        /// <param name="space">This value (or its first 10 characters, if it's longer than that) is used as white space. If this parameter is not provided (or is null), no white space is used.</param>
        /// <returns>The JSON serialized representation of the object.</returns>
        string stringify(object value, Func<string, object, object> replacer, string space);

        /// <summary>
        /// Converts a JavaScript object into a JSON string.
        /// </summary>
        /// <param name="value">The JavaScript object to convert into a JSON string.</param>
        /// <param name="replacer">A function that alters the behavior of the stringification process.</param>
        /// <param name="space">The number of space characters to use as white space; this number is capped at 10 if it's larger than that. Values less than 1 indicate that no space should be used.</param>
        /// <returns>The JSON serialized representation of the object.</returns>
        string stringify(object value, Func<string, object, object> replacer, int space);

        /// <summary>
        /// Converts a JavaScript object into a JSON string.
        /// </summary>
        /// <param name="value">The JavaScript object to convert into a JSON string.</param>
        /// <param name="replacer">Array of String and Number objects that serve as a whitelist for selecting the properties of the value object to be included in the JSON string. If this value is null or not provided, all properties of the object are included in the resulting JSON string.</param>
        /// <returns>The JSON serialized representation of the object.</returns>
        string stringify(object value, object[] replacer);

        /// <summary>
        /// Converts a JavaScript object into a JSON string.
        /// </summary>
        /// <param name="value">The JavaScript object to convert into a JSON string.</param>
        /// <param name="replacer">Array of String and Number objects that serve as a whitelist for selecting the properties of the value object to be included in the JSON string. If this value is null or not provided, all properties of the object are included in the resulting JSON string.</param>
        /// <param name="space">This value (or its first 10 characters, if it's longer than that) is used as white space. If this parameter is not provided (or is null), no white space is used.</param>
        /// <returns>The JSON serialized representation of the object.</returns>
        string stringify(object value, object[] replacer, string space);
        
        /// <summary>
        /// Converts a JavaScript object into a JSON string.
        /// </summary>
        /// <param name="value">The JavaScript object to convert into a JSON string.</param>
        /// <param name="replacer">Array of String and Number objects that serve as a whitelist for selecting the properties of the value object to be included in the JSON string. If this value is null or not provided, all properties of the object are included in the resulting JSON string.</param>
        /// <param name="space">The number of space characters to use as white space; this number is capped at 10 if it's larger than that. Values less than 1 indicate that no space should be used.</param>
        /// <returns>The JSON serialized representation of the object.</returns>
        string stringify(object value, object[] replacer, int space);
    }
}
