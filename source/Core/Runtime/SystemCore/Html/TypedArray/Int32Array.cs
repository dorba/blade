using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Int32Array : TypedArray<int>
    {
        public extern Int32Array(ulong length);

        public extern Int32Array(Int32Array array);

        public extern Int32Array(int[] array);

        public extern Int32Array(ArrayBuffer buffer);

        public extern Int32Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
