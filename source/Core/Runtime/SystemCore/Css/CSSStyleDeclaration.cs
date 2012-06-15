//----------------------------------------------
// Created from July 2011 CSSOM specification
// See: http://www.w3.org/TR/2011/WD-cssom-20110712/
//----------------------------------------------

namespace System.Css
{
    /// <summary>
    /// Represents a single CSS declaration block.
    /// </summary>
    public sealed class CSSStyleDeclaration
    {
        internal CSSStyleDeclaration() { }

        /// <summary>
        /// Gets the CSS rule that contains this declaration block.
        /// </summary>
        [ScriptField]
        public CSSRule parentRule { get; private set; }

        /// <summary>
        /// Gets the number of properties set in the declaration.
        /// </summary>
        [ScriptField]
        public int length { get; private set; }

        /// <summary>
        /// Gets or sets the text value.
        /// </summary>
        [ScriptField]
        public string cssText { get; set; }

        /// <summary>
        /// Gets a property value by name.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <returns>The property value.</returns>
        public string getPropertyValue(string propertyName) { return null; }

        /// <summary>
        /// Removes a property by name.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <returns>The removed property value.</returns>
        public string removeProperty(string propertyName) { return null; }

        /// <summary>
        /// Gets a property priority by name.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <returns>The priority string.</returns>
        public string getPropertyPriority(string propertyName) { return null; }

        /// <summary>
        /// Sets a property value.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <param name="value">The property value.</param>
        public void setProperty(string propertyName, string value) { }

        /// <summary>
        /// Sets a property value.
        /// </summary>
        /// <param name="propertyName">The property name.</param>
        /// <param name="value">The property value.</param>
        /// <param name="priority">The priority.</param>
        public void setProperty(string propertyName, string value, string priority) { }

        /// <summary>
        /// Gets an item from the collection by index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The property value.</returns>
        public string item(int index) { return null; }

        #region CSS Properties

        /// <summary>
        /// Gets or sets the azimuth value.
        /// </summary>
        [ScriptField]
        public string azimuth { get; set; }

        /// <summary>
        /// Gets or sets the background value.
        /// </summary>
        [ScriptField]
        public string background { get; set; }

        /// <summary>
        /// Gets or sets the background attachment value.
        /// </summary>
        [ScriptField]
        public string backgroundAttachment { get; set; }

        /// <summary>
        /// Gets or sets the background color value.
        /// </summary>
        [ScriptField]
        public string backgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the background image value.
        /// </summary>
        [ScriptField]
        public string backgroundImage { get; set; }

        /// <summary>
        /// Gets or sets the background position value.
        /// </summary>
        [ScriptField]
        public string backgroundPosition { get; set; }

        /// <summary>
        /// Gets or sets the background repeat value.
        /// </summary>
        [ScriptField]
        public string backgroundRepeat { get; set; }

        /// <summary>
        /// Gets or sets the border value.
        /// </summary>
        [ScriptField]
        public string border { get; set; }

        /// <summary>
        /// Gets or sets the border collapse value.
        /// </summary>
        [ScriptField]
        public string borderCollapse { get; set; }

        /// <summary>
        /// Gets or sets the border color value.
        /// </summary>
        [ScriptField]
        public string borderColor { get; set; }

        /// <summary>
        /// Gets or sets the border spacing value.
        /// </summary>
        [ScriptField]
        public string borderSpacing { get; set; }

        /// <summary>
        /// Gets or sets the border style value.
        /// </summary>
        [ScriptField]
        public string borderStyle { get; set; }

        /// <summary>
        /// Gets or sets the border top value.
        /// </summary>
        [ScriptField]
        public string borderTop { get; set; }

        /// <summary>
        /// Gets or sets the border right value.
        /// </summary>
        [ScriptField]
        public string borderRight { get; set; }

        /// <summary>
        /// Gets or sets the border bottom value.
        /// </summary>
        [ScriptField]
        public string borderBottom { get; set; }

        /// <summary>
        /// Gets or sets the border left value.
        /// </summary>
        [ScriptField]
        public string borderLeft { get; set; }

        /// <summary>
        /// Gets or sets the border top color value.
        /// </summary>
        [ScriptField]
        public string borderTopColor { get; set; }

        /// <summary>
        /// Gets or sets the border right color value.
        /// </summary>
        [ScriptField]
        public string borderRightColor { get; set; }

        /// <summary>
        /// Gets or sets the border bottom color value.
        /// </summary>
        [ScriptField]
        public string borderBottomColor { get; set; }

        /// <summary>
        /// Gets or sets the border left color value.
        /// </summary>
        [ScriptField]
        public string borderLeftColor { get; set; }

        /// <summary>
        /// Gets or sets the border top style value.
        /// </summary>
        [ScriptField]
        public string borderTopStyle { get; set; }

        /// <summary>
        /// Gets or sets the border right style value.
        /// </summary>
        [ScriptField]
        public string borderRightStyle { get; set; }

        /// <summary>
        /// Gets or sets the border bottom style value.
        /// </summary>
        [ScriptField]
        public string borderBottomStyle { get; set; }

        /// <summary>
        /// Gets or sets the border left style value.
        /// </summary>
        [ScriptField]
        public string borderLeftStyle { get; set; }

        /// <summary>
        /// Gets or sets the border top width value.
        /// </summary>
        [ScriptField]
        public string borderTopWidth { get; set; }

        /// <summary>
        /// Gets or sets the border right width value.
        /// </summary>
        [ScriptField]
        public string borderRightWidth { get; set; }

        /// <summary>
        /// Gets or sets the border bottom width value.
        /// </summary>
        [ScriptField]
        public string borderBottomWidth { get; set; }

        /// <summary>
        /// Gets or sets the border left width value.
        /// </summary>
        [ScriptField]
        public string borderLeftWidth { get; set; }

        /// <summary>
        /// Gets or sets the border width value.
        /// </summary>
        [ScriptField]
        public string borderWidth { get; set; }

        /// <summary>
        /// Gets or sets the bottom value.
        /// </summary>
        [ScriptField]
        public string bottom { get; set; }

        /// <summary>
        /// Gets or sets the caption side value.
        /// </summary>
        [ScriptField]
        public string captionSide { get; set; }

        /// <summary>
        /// Gets or sets the clear value.
        /// </summary>
        [ScriptField]
        public string clear { get; set; }

        /// <summary>
        /// Gets or sets the clip value.
        /// </summary>
        [ScriptField]
        public string clip { get; set; }

        /// <summary>
        /// Gets or sets the color value.
        /// </summary>
        [ScriptField]
        public string color { get; set; }

        /// <summary>
        /// Gets or sets the content value.
        /// </summary>
        [ScriptField]
        public string content { get; set; }

        /// <summary>
        /// Gets or sets the counter increment value.
        /// </summary>
        [ScriptField]
        public string counterIncrement { get; set; }

        /// <summary>
        /// Gets or sets the counter reset value.
        /// </summary>
        [ScriptField]
        public string counterReset { get; set; }

        /// <summary>
        /// Gets or sets the cue value.
        /// </summary>
        [ScriptField]
        public string cue { get; set; }

        /// <summary>
        /// Gets or sets the cue after value.
        /// </summary>
        [ScriptField]
        public string cueAfter { get; set; }

        /// <summary>
        /// Gets or sets the cue before value.
        /// </summary>
        [ScriptField]
        public string cueBefore { get; set; }

        /// <summary>
        /// Gets or sets the cursor value.
        /// </summary>
        [ScriptField]
        public string cursor { get; set; }

        /// <summary>
        /// Gets or sets the direction value.
        /// </summary>
        [ScriptField]
        public string direction { get; set; }

        /// <summary>
        /// Gets or sets the display value.
        /// </summary>
        [ScriptField]
        public string display { get; set; }

        /// <summary>
        /// Gets or sets the elevation value.
        /// </summary>
        [ScriptField]
        public string elevation { get; set; }

        /// <summary>
        /// Gets or sets the empty cells value.
        /// </summary>
        [ScriptField]
        public string emptyCells { get; set; }

        /// <summary>
        /// Gets or sets the css float value.
        /// </summary>
        [ScriptField]
        public string cssFloat { get; set; }

        /// <summary>
        /// Gets or sets the font value.
        /// </summary>
        [ScriptField]
        public string font { get; set; }

        /// <summary>
        /// Gets or sets the font family value.
        /// </summary>
        [ScriptField]
        public string fontFamily { get; set; }

        /// <summary>
        /// Gets or sets the font size value.
        /// </summary>
        [ScriptField]
        public string fontSize { get; set; }

        /// <summary>
        /// Gets or sets the font size adjust value.
        /// </summary>
        [ScriptField]
        public string fontSizeAdjust { get; set; }

        /// <summary>
        /// Gets or sets the font stretch value.
        /// </summary>
        [ScriptField]
        public string fontStretch { get; set; }

        /// <summary>
        /// Gets or sets the font style value.
        /// </summary>
        [ScriptField]
        public string fontStyle { get; set; }

        /// <summary>
        /// Gets or sets the font variant value.
        /// </summary>
        [ScriptField]
        public string fontVariant { get; set; }

        /// <summary>
        /// Gets or sets the font weight value.
        /// </summary>
        [ScriptField]
        public string fontWeight { get; set; }

        /// <summary>
        /// Gets or sets the height value.
        /// </summary>}
        [ScriptField]
        public string height { get; set; }

        /// <summary>
        /// Gets or sets the left value.
        /// </summary>
        [ScriptField]
        public string left { get; set; }

        /// <summary>
        /// Gets or sets the letter spacing value.
        /// </summary>
        [ScriptField]
        public string letterSpacing { get; set; }

        /// <summary>
        /// Gets or sets the line height value.
        /// </summary>
        [ScriptField]
        public string lineHeight { get; set; }

        /// <summary>
        /// Gets or sets the list style value.
        /// </summary>
        [ScriptField]
        public string listStyle { get; set; }

        /// <summary>
        /// Gets or sets the list style image value.
        /// </summary>
        [ScriptField]
        public string listStyleImage { get; set; }

        /// <summary>
        /// Gets or sets the list style position value.
        /// </summary>
        [ScriptField]
        public string listStylePosition { get; set; }

        /// <summary>
        /// Gets or sets the list style type value.
        /// </summary>
        [ScriptField]
        public string listStyleType { get; set; }

        /// <summary>
        /// Gets or sets the margin value.
        /// </summary>
        [ScriptField]
        public string margin { get; set; }

        /// <summary>
        /// Gets or sets the margin top value.
        /// </summary>
        [ScriptField]
        public string marginTop { get; set; }

        /// <summary>
        /// Gets or sets the margin right value.
        /// </summary>
        [ScriptField]
        public string marginRight { get; set; }

        /// <summary>
        /// Gets or sets the margin bottom value.
        /// </summary>
        [ScriptField]
        public string marginBottom { get; set; }

        /// <summary>
        /// Gets or sets the margin left value.
        /// </summary>
        [ScriptField]
        public string marginLeft { get; set; }

        /// <summary>
        /// Gets or sets the marker offset value.
        /// </summary>
        [ScriptField]
        public string markerOffset { get; set; }

        /// <summary>
        /// Gets or sets the marks value.
        /// </summary>
        [ScriptField]
        public string marks { get; set; }

        /// <summary>
        /// Gets or sets the max height value.
        /// </summary>
        [ScriptField]
        public string maxHeight { get; set; }

        /// <summary>
        /// Gets or sets the max width value.
        /// </summary>
        [ScriptField]
        public string maxWidth { get; set; }

        /// <summary>
        /// Gets or sets the min height value.
        /// </summary>
        [ScriptField]
        public string minHeight { get; set; }

        /// <summary>
        /// Gets or sets the min width value.
        /// </summary>
        [ScriptField]
        public string minWidth { get; set; }

        /// <summary>
        /// Gets or sets the orphans value.
        /// </summary>
        [ScriptField]
        public string orphans { get; set; }

        /// <summary>
        /// Gets or sets the outline value.
        /// </summary>
        [ScriptField]
        public string outline { get; set; }

        /// <summary>
        /// Gets or sets the outline color value.
        /// </summary>
        [ScriptField]
        public string outlineColor { get; set; }

        /// <summary>
        /// Gets or sets the outline style value.
        /// </summary>
        [ScriptField]
        public string outlineStyle { get; set; }

        /// <summary>
        /// Gets or sets the outline width value.
        /// </summary>
        [ScriptField]
        public string outlineWidth { get; set; }

        /// <summary>
        /// Gets or sets the overflow value.
        /// </summary>
        [ScriptField]
        public string overflow { get; set; }

        /// <summary>
        /// Gets or sets the padding value.
        /// </summary>
        [ScriptField]
        public string padding { get; set; }

        /// <summary>
        /// Gets or sets the padding top value.
        /// </summary>
        [ScriptField]
        public string paddingTop { get; set; }

        /// <summary>
        /// Gets or sets the padding right value.
        /// </summary>
        [ScriptField]
        public string paddingRight { get; set; }

        /// <summary>
        /// Gets or sets the padding bottom value.
        /// </summary>
        [ScriptField]
        public string paddingBottom { get; set; }

        /// <summary>
        /// Gets or sets the padding left value.
        /// </summary>
        [ScriptField]
        public string paddingLeft { get; set; }

        /// <summary>
        /// Gets or sets the page value.
        /// </summary>
        [ScriptField]
        public string page { get; set; }

        /// <summary>
        /// Gets or sets the page break after value.
        /// </summary>
        [ScriptField]
        public string pageBreakAfter { get; set; }

        /// <summary>
        /// Gets or sets the page break before value.
        /// </summary>
        [ScriptField]
        public string pageBreakBefore { get; set; }

        /// <summary>
        /// Gets or sets the page break inside value.
        /// </summary>
        [ScriptField]
        public string pageBreakInside { get; set; }

        /// <summary>
        /// Gets or sets the pause value.
        /// </summary>
        [ScriptField]
        public string pause { get; set; }

        /// <summary>
        /// Gets or sets the pause after value.
        /// </summary>
        [ScriptField]
        public string pauseAfter { get; set; }

        /// <summary>
        /// Gets or sets the pause before value.
        /// </summary>
        [ScriptField]
        public string pauseBefore { get; set; }

        /// <summary>
        /// Gets or sets the pitch value.
        /// </summary>
        [ScriptField]
        public string pitch { get; set; }

        /// <summary>
        /// Gets or sets the pitch range value.
        /// </summary>
        [ScriptField]
        public string pitchRange { get; set; }

        /// <summary>
        /// Gets or sets the play during value.
        /// </summary>
        [ScriptField]
        public string playDuring { get; set; }

        /// <summary>
        /// Gets or sets the position value.
        /// </summary>
        [ScriptField]
        public string position { get; set; }

        /// <summary>
        /// Gets or sets the quotes value.
        /// </summary>
        [ScriptField]
        public string quotes { get; set; }

        /// <summary>
        /// Gets or sets the richness value.
        /// </summary>
        [ScriptField]
        public string richness { get; set; }

        /// <summary>
        /// Gets or sets the right value.
        /// </summary>
        [ScriptField]
        public string right { get; set; }

        /// <summary>
        /// Gets or sets the size value.
        /// </summary>
        [ScriptField]
        public string size { get; set; }

        /// <summary>
        /// Gets or sets the speak value.
        /// </summary>
        [ScriptField]
        public string speak { get; set; }

        /// <summary>
        /// Gets or sets the speak header value.
        /// </summary>
        [ScriptField]
        public string speakHeader { get; set; }

        /// <summary>
        /// Gets or sets the speak numeral value.
        /// </summary>
        [ScriptField]
        public string speakNumeral { get; set; }

        /// <summary>
        /// Gets or sets the speak punctuation value.
        /// </summary>
        [ScriptField]
        public string speakPunctuation { get; set; }

        /// <summary>
        /// Gets or sets the speech rate value.
        /// </summary>
        [ScriptField]
        public string speechRate { get; set; }

        /// <summary>
        /// Gets or sets the stress value.
        /// </summary>
        [ScriptField]
        public string stress { get; set; }

        /// <summary>
        /// Gets or sets the table layout value.
        /// </summary>
        [ScriptField]
        public string tableLayout { get; set; }

        /// <summary>
        /// Gets or sets the text align value.
        /// </summary>
        [ScriptField]
        public string textAlign { get; set; }

        /// <summary>
        /// Gets or sets the text decoration value.
        /// </summary>
        [ScriptField]
        public string textDecoration { get; set; }

        /// <summary>
        /// Gets or sets the text indent value.
        /// </summary>
        [ScriptField]
        public string textIndent { get; set; }

        /// <summary>
        /// Gets or sets the text shadow value.
        /// </summary>
        [ScriptField]
        public string textShadow { get; set; }

        /// <summary>
        /// Gets or sets the text transform value.
        /// </summary>
        [ScriptField]
        public string textTransform { get; set; }

        /// <summary>
        /// Gets or sets the top value.
        /// </summary>
        [ScriptField]
        public string top { get; set; }

        /// <summary>
        /// Gets or sets the unicode bidi value.
        /// </summary>
        [ScriptField]
        public string unicodeBidi { get; set; }

        /// <summary>
        /// Gets or sets the vertical align value.
        /// </summary>
        [ScriptField]
        public string verticalAlign { get; set; }

        /// <summary>
        /// Gets or sets the visibility value.
        /// </summary>
        [ScriptField]
        public string visibility { get; set; }

        /// <summary>
        /// Gets or sets the voice family value.
        /// </summary>
        [ScriptField]
        public string voiceFamily { get; set; }

        /// <summary>
        /// Gets or sets the volume value.
        /// </summary>
        [ScriptField]
        public string volume { get; set; }

        /// <summary>
        /// Gets or sets the white space value.
        /// </summary>
        [ScriptField]
        public string whiteSpace { get; set; }

        /// <summary>
        /// Gets or sets the widows value.
        /// </summary>
        [ScriptField]
        public string widows { get; set; }

        /// <summary>
        /// Gets or sets the width value.
        /// </summary>
        [ScriptField]
        public string width { get; set; }

        /// <summary>
        /// Gets or sets the word spacing value.
        /// </summary>
        [ScriptField]
        public string wordSpacing { get; set; }

        /// <summary>
        /// Gets or sets the z-index value.
        /// </summary>
        [ScriptField]
        public string zIndex { get; set; }

        #endregion
    }
}