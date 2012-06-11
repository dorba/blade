//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Provides methods for performing operations that are independent of any particular instance of the document object model.
	/// </summary>
    public abstract class DOMImplementation
    {
        internal DOMImplementation() { }

        /// <summary>
        /// Gets a value indicating whether of the a feature is supported.
        /// </summary>
        /// <param name="feature">The feature name.</param>
        /// <param name="version">The feature version.</param>
        /// <returns>True if the feature is supported, false otherwise.</returns>
        public bool hasFeature(string feature, string version) { return false; }

        /// <summary>
        /// Creates a new <see cref="DocumentType"/> node.
        /// </summary>
        /// <param name="qualifiedName">The qualified name.</param>
        /// <param name="publicId">The public identifier.</param>
        /// <param name="systemId">The system identifier.</param>
        /// <returns>The newly created node.</returns>
        public DocumentType createDocumentType(string qualifiedName, string publicId, string systemId) { return null; }

        /// <summary>
        /// Creates a new <see cref="Document"/> node.
        /// </summary>
        /// <param name="namespaceURI">The namespace.</param>
        /// <param name="qualifiedName">The qualified name.</param>
        /// <param name="doctype">The document type node.</param>
        /// <returns>The newly created document.</returns>
        public Document createDocument(string namespaceURI, string qualifiedName, DocumentType doctype) { return null; }

        /// <summary>
        /// Creates a new document, with a basic HTML tree constructed.
        /// </summary>
        /// <param name="title">The title of the document.</param>
        /// <returns>The newly created document.</returns>
        public Document createHTMLDocument(string title) { return null; }
    }
}
