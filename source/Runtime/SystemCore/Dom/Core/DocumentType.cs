//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Represents a document type node.
	/// </summary>
    public sealed class DocumentType : Node
    {
        internal DocumentType() { }

		/// <summary>
		/// Gets the document type name.
		/// </summary>
		[ScriptField]
		public string name { get; private set; }

		/// <summary>
		/// Gets the public identifier.
		/// </summary>
		[ScriptField]
		public string publicId { get; private set; }

		/// <summary>
		/// Gets the system identifier.
		/// </summary>
		[ScriptField]
		public string systemId { get; private set; }
    }
}