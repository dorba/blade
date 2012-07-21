using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class DataView : ArrayBufferView
    {
        public extern DataView(ArrayBuffer buffer);

        public extern DataView(ArrayBuffer buffer, Number byteOffset = null, Number byteLength = null);

        public extern sbyte getInt8(ulong byteOffset);

        public extern byte getUint8(ulong byteOffset);

        public extern short getInt16(ulong byteOffset);

        public extern short getInt16(ulong byteOffset, bool littleEndian);

        public extern ushort getUint16(ulong byteOffset);

        public extern ushort getUint16(ulong byteOffset, bool littleEndian);

        public extern long getInt32(ulong byteOffset);

        public extern long getInt32(ulong byteOffset, bool littleEndian);

        public extern ulong getUint32(ulong byteOffset);

        public extern ulong getUint32(ulong byteOffset, bool littleEndian);

        public extern float getFloat32(ulong byteOffset);

        public extern float getFloat32(ulong byteOffset, bool littleEndian);

        public extern double getFloat64(ulong byteOffsetc);

        public extern double getFloat64(ulong byteOffset, bool littleEndian);

        public extern void setInt8(ulong byteOffset, sbyte value);

        public extern void setUint8(ulong byteOffset, byte value);
        
        public extern void setInt16(ulong byteOffset, short value);

        public extern void setInt16(ulong byteOffset, short value, bool littleEndian);

        public extern void setUint16(ulong byteOffset, ushort value);

        public extern void setUint16(ulong byteOffset, ushort value, bool littleEndian);

        public extern void setInt32(ulong byteOffset, long value);

        public extern void setInt32(ulong byteOffset, long value, bool littleEndian);

        public extern void setUint32(ulong byteOffset, ulong value);

        public extern void setUint32(ulong byteOffset, ulong value, bool littleEndian);

        public extern void setFloat32(ulong byteOffset, float value);

        public extern void setFloat32(ulong byteOffset, float value, bool littleEndian);

        public extern void setFloat64(ulong byteOffset, double value);

        public extern void setFloat64(ulong byteOffset, double value, bool littleEndian);
    }
}
