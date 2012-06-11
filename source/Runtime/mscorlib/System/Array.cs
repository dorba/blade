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

		public Array concat(params object[] items) { return null; }

		public string join() { return null; }

		public string join(string separator) { return null; }

		public object pop() { return null; }

		public int push(params object[] items) { return 0; }

		public void reverse() { }

		public object shift() { return null; }

		public Array slice(int startIndex) { return null; }
		public Array slice(int startIndex, int endIndex) { return null; }

		public void sort() { }
		public void sort(Func<int, object, object> sortFunc) { }

		public Array splice(int startIndex) { return null; }
		public Array splice(int startIndex, int count) { return null; }
		public Array splice(int startIndex, int count, params object[] items) { return null; }

		public int unshift(params object[] items) { return 0; }

		public int indexOf(object value) { return 0; }
		public int indexOf(object value, int startIndex) { return 0; }

		public int lastIndexOf(object value) { return 0; }
		public int lastIndexOf(object value, int startIndex) { return 0; }

		public Array filter(Func<bool> callback, object thisObj = null) { return null; }
		public Array filter(Func<bool, object> callback, object thisObj = null) { return null; }
		public Array filter(Func<bool, object, int> callback, object thisObj = null) { return null; }
		public Array filter(Func<bool, object, int, Array> callback, object thisObj = null) { return null; }

		public void forEach(Action<object> callback, object thisObj = null) { }
		public void forEach(Action<object, int> callback, object thisObj = null) { }
		public void forEach(Action<object, int, Array> callback, object thisObj = null) { }

		public bool every(Func<bool> callback, object thisObj = null) { return false; }
		public bool every(Func<bool, object> callback, object thisObj = null) { return false; }
		public bool every(Func<bool, object, int> callback, object thisObj = null) { return false; }
		public bool every(Func<bool, object, int, Array> callback, object thisObj = null) { return false; }

		public Array map(Func<object> callback, object thisObj = null) { return null; }
		public Array map(Func<object, object> callback, object thisObj = null) { return null; }
		public Array map(Func<object, object, int> callback, object thisObj = null) { return null; }
		public Array map(Func<object, object, int, Array> callback, object thisObj = null) { return null; }

		public bool some(Func<bool> callback, object thisObj = null) { return false; }
		public bool some(Func<bool, object> callback, object thisObj = null) { return false; }
		public bool some(Func<bool, object, int> callback, object thisObj = null) { return false; }
		public bool some(Func<bool, object, int, Array> callback, object thisObj = null) { return false; }

		public object reduce(Func<object, object, object> callback, object initialValue = null) { return null; }
		public object reduce(Func<object, object, object, int> callback, object initialValue = null) { return null; }
		public object reduce(Func<object, object, object, int, Array> callback, object initialValue = null) { return null; }

		public object reduceRight(Func<object, object, object> callback, object initialValue = null) { return null; }
		public object reduceRight(Func<object, object, object, int> callback, object initialValue = null) { return null; }
		public object reduceRight(Func<object, object, object, int, Array> callback, object initialValue = null) { return null; }

		/// <summary>
		/// Determines whether or not an object is an array.
		/// </summary>
		/// <param name="obj">The object to check.</param>
		/// <returns>True if the object is a array, false otherwise.</returns>
		public static bool isArray(object obj) { return false; }

        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }

    public class ArrayEnumerator : IEnumerator
    {
        public ArrayEnumerator(Array array)
        {
        }

        public bool MoveNext()
        {
            return false;   
        }

        public object Current
        {
            get { return null;  }
        }

        public void Reset()
        {
            
        }
    }
}