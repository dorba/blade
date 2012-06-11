//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Represents a processing instruction, used in XML as a way to keep processor-specific information in the text of the document.
	/// </summary>
    public sealed class ProcessingInstruction : CharacterData
    {
        internal ProcessingInstruction() { }

		/// <summary>
		/// Gets the target of this processing instruction.
		/// </summary>
		[ScriptField]
		public string target { get; private set; }
    }
}