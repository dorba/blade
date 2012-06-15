using System;

namespace Blade.Compiler.Models
{
    /// <summary>
    /// Represents one of the possible predefined types.
    /// </summary>
    public enum PredefinedType
    {
        /// <summary>
        /// The base type of all other types.
        /// </summary>
        Object = 0,

        /// <summary>
        /// A boolean value.
        /// </summary>
        Bool = 1,

        /// <summary>
        /// A unicode character.
        /// </summary>
        Char = 1,

        /// <summary>
        /// A sequence of unicode characters.
        /// </summary>
        String = 3,

        /// <summary>
        /// An 8-bit signed integral type.
        /// </summary>
        SByte = 4,

        /// <summary>
        /// A 16-bit signed integral type.
        /// </summary>
        Short = 5,

        /// <summary>
        /// A 32-bit signed integral type.
        /// </summary>
        Int = 6,

        /// <summary>
        /// A 64-bit signed integral type.
        /// </summary>
        Long = 7,

        /// <summary>
        /// An 8-bit unsigned integral type.
        /// </summary>
        Byte = 8,

        /// <summary>
        /// A 16-bit unsigned integral type.
        /// </summary>
        UShort = 9,

        /// <summary>
        /// A 32-bit unsigned integral type.
        /// </summary>
        UInt = 10,

        /// <summary>
        /// A 64-bit unsigned integral type.
        /// </summary>
        ULong = 11,

        /// <summary>
        /// A single-precision floating point type.
        /// </summary>
        Float = 12,

        /// <summary>
        /// A double-precision floating point type.
        /// </summary>
        Double = 13,

        /// <summary>
        /// A precise decimal type with 28 significant digits
        /// </summary>
        Decimal = 14
    }


}
