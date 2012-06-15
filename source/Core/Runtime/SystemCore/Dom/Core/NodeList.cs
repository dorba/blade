//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Represents an ordered list of nodes.
	/// </summary>
	public sealed class NodeList
	{
        internal NodeList() { }

		/// <summary>
		/// Gets the number of nodes in the list.
		/// </summary>
		[ScriptField]
		public int length { get; private set; }

		/// <summary>
		/// Gets the item at the specified index in the list.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <returns>A node item.</returns>
		public Node item(int index) { return null; }
	}
}