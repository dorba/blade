using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Float64Array : TypedArray<double>
    {
        public extern Float64Array(ulong length);

        public extern Float64Array(Float64Array array);

        public extern Float64Array(double[] array);

        public extern Float64Array(ArrayBuffer buffer);

        public extern Float64Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
