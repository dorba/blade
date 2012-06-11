//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// The base object for <see cref="Text"/>, <see cref="Comment"/>, and <see cref="ProcessingInstruction"/> objects.
    /// </summary>
    public abstract class CharacterData : Node
    {
		internal CharacterData() { }

		/// <summary>
		/// Gets or sets the node character data.
		/// </summary>
		[ScriptField]
		public string data { get; set; }

		/// <summary>
		/// Gets the number of characters in the node.
		/// </summary>
		[ScriptField]
		public int length { get; private set; }

		/// <summary>
		/// Extracts a range of characters from the node.
		/// </summary>
		/// <param name="offset">The start index.</param>
		/// <param name="count">The number of characters to extract.</param>
		/// <returns>The extracted text.</returns>
        public string substringData(int offset, int count) { return null; }

		/// <summary>
		/// Appends text to the end of the node.
		/// </summary>
		/// <param name="arg">The text to append.</param>
        public void appendData(string arg) { }

		/// <summary>
		/// Inserts text at a specified offset in the node.
		/// </summary>
		/// <param name="offset">The start index.</param>
		/// <param name="arg">The text to insert.</param>
        public void insertData(int offset, string arg) { }

		/// <summary>
		/// Removes text at a specified offset in the node.
		/// </summary>
		/// <param name="offset">The start index.</param>
		/// <param name="count">The number of characters to remove.</param>
        public void deleteData(int offset, int count) { }

		/// <summary>
		/// Replaces text at a specified offset in the node.
		/// </summary>
		/// <param name="offset">The start index.</param>
		/// <param name="count">The number of characters to replace.</param>
		/// <param name="arg">The text to insert.</param>
        public void replaceData(int offset, int count, string arg) { }
    }
}
