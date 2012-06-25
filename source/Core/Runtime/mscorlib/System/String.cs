
namespace System
{
    /// <summary>
    /// System string implementation, exposed as ECMA string.
    /// </summary>
    public sealed class String
    {
        /// <summary>
        /// Gets the number of characters in the string.
        /// </summary>
        [ScriptField]
        public int length { get; private set; }

        /// <summary>
        /// Returns the character at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>A single character string.</returns>
        public string charAt(int index) { return null; }

        /// <summary>
        /// Returns the Unicode of the character at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>A unicode value.</returns>
        public int charCodeAt(int index) { return 0; }

        /// <summary>
        /// Joins two or more strings, and returns a copy of the joined strings.
        /// </summary>
        /// <param name="values">The values to join.</param>
        /// <returns>The resulting string.</returns>
        public string concat(params string[] values) { return null; }

        /// <summary>
        /// Converts Unicode values to characters.
        /// </summary>
        /// <param name="charCodes">The values to convert.</param>
        /// <returns>The resulting string.</returns>
        public string fromCharCode(params int[] charCodes) { return null; }

        /// <summary>
        /// Returns the position of the first found occurrence of a specified value in a string.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns>The start index of the matching value, or -1 if one is not found.</returns>
        public int indexOf(string value) { return 0; }

        /// <summary>
        /// Returns the position of the last found occurrence of a specified value in a string.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns>The start index of the matching value, or -1 if one is not found.</returns>
        public int lastIndexOf(string value) { return 0; }

        /// <summary>
        /// Searches for a match between a regular expression and a string, and returns the matches.
        /// </summary>
        /// <param name="regExp">The regular expression to use.</param>
        /// <returns>An array of matching values.</returns>
        public string[] match(IRegularExpression regExp) { return null; } 

        /// <summary>
        /// Replaces all matches with a new value.
        /// </summary>
        /// <param name="oldValue">The value to search for.</param>
        /// <param name="newValue">The value to replace with.</param>
        /// <returns>The resulting string.</returns>
        public string replace(string oldValue, string newValue) { return null; }

        /// <summary>
        /// Replaces all matches with a new value.
        /// </summary>
        /// <param name="regExp">The regular expression to search with.</param>
        /// <param name="newValue">The value to replace with.</param>
        /// <returns>The resulting string.</returns>
        public string replace(IRegularExpression regExp, string newValue) { return null; } 

        /// <summary>
        /// Searches for a match between a regular expression and a string, and returns the position of the match.
        /// </summary>
        /// <param name="regExp">The regular expression to search with.</param>
        /// <returns>Returns the index of the match, or -1 if one is not found.</returns>
        public int search(IRegularExpression regExp) { return 0; } 

        /// <summary>
        /// Extracts a section of a string.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <returns>The extracted string.</returns>
        public string slice(int startIndex) { return null; } 

        /// <summary>
        /// Extracts a section of a string.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <param name="endIndex">The index to stop at.</param>
        /// <returns>The extracted string.</returns>
        public string slice(int startIndex, int endIndex) { return null; } 

        /// <summary>
        /// Splits a string into an array of substrings.
        /// </summary>
        /// <param name="separator">The value to split on.</param>
        /// <returns>An array of the split values.</returns>
        public string[] split(string separator) { return null; }

        /// <summary>
        /// Splits a string into an array of substrings.
        /// </summary>
        /// <param name="separator">The value to split on.</param>
        /// <param name="limit">A limit on the number of splits.</param>
        /// <returns>An array of the split values.</returns>
        public string[] split(string separator, int limit) { return null; }

        /// <summary>
        /// Extracts a section of a string.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <returns>The extracted string.</returns>
        public string substr(int startIndex) { return null; }

        /// <summary>
        /// Extracts a section of a string.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <param name="length">The number of characters to extract.</param>
        /// <returns>The extracted string.</returns>
        public string substr(int startIndex, int length) { return null; }

        /// <summary>
        /// Extracts a section of a string.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <returns>The extracted string.</returns>
        public string substring(int startIndex) { return null; } 

        /// <summary>
        /// Extracts a section of a string.
        /// </summary>
        /// <param name="startIndex">The index to begin at.</param>
        /// <param name="endIndex">The index to stop at.</param>
        /// <returns>The extracted string.</returns>
        public string substring(int startIndex, int endIndex) { return null; } 

        /// <summary>
        /// Converts a string to lowercase letters.
        /// </summary>
        /// <returns>The resulting string.</returns>
        public string toLowerCase() { return null; }

        /// <summary>
        /// Converts a string to uppercase letters.
        /// </summary>
        /// <returns>The resulting string.</returns>
        public string toUpperCase() { return null; }

        #region Compiler Required Methods
#pragma warning disable 1591 // disable comment warnings

        // these declarations are required to concat strings (expressions like "1" + "2")
        // otherwise the C# compiler will throw an exception
        // we can probably alter this behavior if we move to using Roslyn to emit the assembly
        public static string Concat(string str1, string str2) { return null; }
        public static string Concat(string str1, string str2, string str3) { return null; }
        public static string Concat(string str1, string str2, string str3, string str4) { return null; }
        public static string Concat(params string[] strs) { return null; }
        public static string Concat(object obj) { return null; }
        public static string Concat(object obj1, object obj2) { return null; }
        public static string Concat(object obj1, object obj2, object obj3) { return null; }
        public static string Concat(object obj1, object obj2, object obj3, object obj4) { return null; }
        public static string Concat(params object[] objs) { return null; }

        // operator overloads (also required by compiler)
        public static bool operator ==(string x, string y) { return false; }
        public static bool operator !=(string x, string y) { return false; }

#pragma warning restore 1591 // restore comment warnings
        #endregion
    }
}


