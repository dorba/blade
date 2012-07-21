using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Uint32Array : TypedArray<uint>
    {
        public extern Uint32Array(ulong length);

        public extern Uint32Array(Uint32Array array);

        public extern Uint32Array(uint[] array);

        public extern Uint32Array(ArrayBuffer buffer);

        public extern Uint32Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
