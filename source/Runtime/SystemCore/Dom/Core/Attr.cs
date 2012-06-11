//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Represents an attribute of an <see cref="Element"/> node.
	/// </summary>
	public sealed class Attr
	{
        internal Attr() { }

		/// <summary>
		/// Gets the attribute name.
		/// </summary>
		[ScriptField]
		public string name { get; private set; }

		/// <summary>
		/// Gets or sets the value of the attribute.
		/// </summary>
		[ScriptField]
		public string value { get; set; }
	}
}
