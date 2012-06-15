//----------------------------------------------
// Created from DOM4 specification
// See: http://www.w3.org/TR/2012/WD-dom-20120405/
//----------------------------------------------

namespace System.Dom
{
	/// <summary>
	/// Represents an exception that occurs while executing a process within the DOM.
	/// </summary>
    public sealed class DOMException : Exception
    {
        internal DOMException() { }

        /// <summary>
        /// The index is not in the allowed range. 
        /// </summary>
        public const int INDEX_SIZE_ERR = 1;

        /// <summary>
        /// The string is not of a valid size.
        /// </summary>
        public const int DOMSTRING_SIZE_ERR = 2;

        /// <summary>
        /// The operation would yield an incorrect node tree. 
        /// </summary>
        public const int HIERARCHY_REQUEST_ERR = 3;

        /// <summary>
        /// The object is in the wrong document. 
        /// </summary>
        public const int WRONG_DOCUMENT_ERR = 4;

        /// <summary>
        /// The string contains invalid characters. 
        /// </summary>
        public const int INVALID_CHARACTER_ERR = 5;

        /// <summary>
        /// Data is not allowed.
        /// </summary>
        public const int NO_DATA_ALLOWED_ERR = 6;

        /// <summary>
        /// The object can not be modified. 
        /// </summary>
        public const int NO_MODIFICATION_ALLOWED_ERR = 7;

        /// <summary>
        /// The object can not be found here. 
        /// </summary>
        public const int NOT_FOUND_ERR = 8;

        /// <summary>
        /// The operation is not supported. 
        /// </summary>
        public const int NOT_SUPPORTED_ERR = 9;

        /// <summary>
        /// The attribute is already in use.
        /// </summary>
        public const int INUSE_ATTRIBUTE_ERR = 10;

        /// <summary>
        /// The object is in an invalid state. 
        /// </summary>
        public const int INVALID_STATE_ERR = 11;

        /// <summary>
        /// The string did not match the expected pattern. 
        /// </summary>
        public const int SYNTAX_ERR = 12;

        /// <summary>
        /// The object can not be modified in this way. 
        /// </summary>
        public const int INVALID_MODIFICATION_ERR = 13;

        /// <summary>
        /// The operation is not allowed by Namespaces in XML.
        /// </summary>
        public const int NAMESPACE_ERR = 14;

        /// <summary>
        /// The object does not support the operation or argument. 
        /// </summary>
        public const int INVALID_ACCESS_ERR = 15;

        /// <summary>
        /// The object is not valid.
        /// </summary>
        public const int VALIDATION_ERR = 16;

        /// <summary>
        /// The type of the object does not match the expected type. 
        /// </summary>
        public const int TYPE_MISMATCH_ERR = 17;

        /// <summary>
        /// The operation is insecure. 
        /// </summary>
        public const int SECURITY_ERR = 18;

        /// <summary>
        /// A network error occurred. 
        /// </summary>
        public const int NETWORK_ERR = 19;

        /// <summary>
        /// The operation was aborted. 
        /// </summary>
        public const int ABORT_ERR = 20;

        /// <summary>
        /// The given URL does not match another URL. 
        /// </summary>
        public const int URL_MISMATCH_ERR = 21;

        /// <summary>
        /// The quota has been exceeded. 
        /// </summary>
        public const int QUOTA_EXCEEDED_ERR = 22;

        /// <summary>
        /// The operation timed out. 
        /// </summary>
        public const int TIMEOUT_ERR = 23;

        /// <summary>
        /// The supplied node is incorrect or has an incorrect ancestor for this operation.
        /// </summary>
        public const int INVALID_NODE_TYPE_ERR = 24;

        /// <summary>
        /// The object can not be cloned. 
        /// </summary>
        public const int DATA_CLONE_ERR = 25;

		/// <summary>
		/// Gets or sets the exception code.
		/// </summary>
		[ScriptField]
		public int code { get; set; }
    }
}