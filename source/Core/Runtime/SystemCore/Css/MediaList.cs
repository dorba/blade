//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Represents a collection of media types.
    /// </summary>
    public sealed class MediaList
    {
		internal MediaList() { }

        /// <summary>
        /// Gets the number of items in the collection.
        /// </summary>
		[ScriptField]
		public int length { get; private set; }

        /// <summary>
        /// Gets or sets the text for the media list.
        /// </summary>
        [ScriptField]
        public string mediaText { get; set; }

        /// <summary>
        /// Gets a specific item by index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The media type name.</returns>
        public string item(int index) { return null; }

        /// <summary>
        /// Removes an item by name.
        /// </summary>
        /// <param name="oldMedium">The type name to remove.</param>
        public void deleteMedium(string oldMedium) { }

        /// <summary>
        /// Adds a new item by name.
        /// </summary>
        /// <param name="newMedium">The type name to add.</param>
        public void appendMedium(string newMedium) { }
    }
}