
namespace System
{
	/// <summary>
	/// System string implementation, exposed as ECMA string.
	/// </summary>
    public sealed class String
    {
        public string charAt(int index) { return null; }	//Returns the character at the specified index
        public int charCodeAt(int index) { return 0; } 	//Returns the Unicode of the character at the specified index
        public string concat(params string[] values) { return null; } 	//Joins two or more strings, and returns a copy of the joined strings
        public string fromCharCode(params int[] charCodes) { return null; } 	//Converts Unicode values to characters
        public int indexOf(string value) { return 0; } 	//Returns the position of the first found occurrence of a specified value in a string
        public int lastIndexOf(string value) { return 0; } 	//Returns the position of the last found occurrence of a specified value in a string
        public object match(IRegularExpression regExp) { return null; } 	//Searches for a match between a regular expression and a string, and returns the matches
        public string replace(string oldValue, string newValue) { return null; } 	//Searches for a match between a substring (or regular expression) and a string, and replaces the matched substring with a new substring
        public int search(IRegularExpression regExp) { return 0; } 	//Searches for a match between a regular expression and a string, and returns the position of the match
        public string slice(int startIndex) { return null; } 	//Extracts a part of a string and returns a new string
        public string slice(int startIndex, int endIndex) { return null; } 	//Extracts a part of a string and returns a new string
        public string[] split(string separator) { return null; }	//Splits a string into an array of substrings
        public string[] split(string separator, int limit) { return null; }	//Splits a string into an array of substrings
        public string substr(int startIndex) { return null; }	//Extracts the characters from a string, beginning at a specified start position, and through the specified number of character
        public string substr(int startIndex, int length) { return null; }	//Extracts the characters from a string, beginning at a specified start position, and through the specified number of character
        public string substring(int startIndex) { return null; } 	//Extracts the characters from a string, between two specified indices
        public string substring(int startIndex, int endIndex) { return null; } 	//Extracts the characters from a string, between two specified indices
        public string toLowerCase() { return null; }	//Converts a string to lowercase letters
        public string toUpperCase() { return null; }	//Converts a string to uppercase letters

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
    }
}


