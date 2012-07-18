using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Int8Array : TypedArray<sbyte>
    {
        public extern Int8Array(ulong length);

        public extern Int8Array(Int8Array array);

        public extern Int8Array(sbyte[] array);

        public extern Int8Array(ArrayBuffer buffer);

        public extern Int8Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
