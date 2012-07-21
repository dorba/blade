using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Uint16Array : TypedArray<ushort>
    {
        public extern Uint16Array(ulong length);

        public extern Uint16Array(Uint16Array array);

        public extern Uint16Array(ushort[] array);

        public extern Uint16Array(ArrayBuffer buffer);

        public extern Uint16Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
