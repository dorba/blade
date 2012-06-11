//----------------------------------------------
// Created from DOM Level 2 specification
// See: http://www.w3.org/TR/2000/REC-DOM-Level-2-Style-20001113/css.html
//----------------------------------------------

namespace System.Dom
{
    public sealed class CSSRuleList
    {
        [ScriptField]
        public int length
        {
            get { return 0; }
        }

        public CSSRule item(int index) { return null; }
    }
}