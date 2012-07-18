using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Int16Array : TypedArray<short>
    {
        public extern Int16Array(ulong length);

        public extern Int16Array(Int16Array array);

        public extern Int16Array(short[] array);

        public extern Int16Array(ArrayBuffer buffer);

        public extern Int16Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
