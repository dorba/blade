
namespace System
{
    /// <summary>
    /// Specifies the application elements on which it is valid to apply an attribute.
    /// </summary>
    [Flags]
    public enum AttributeTargets
    {
        /// <summary>
        /// Attribute can be applied to an assembly.
        /// </summary>
        Assembly = 0x0001,

        /// <summary>
        /// Attribute can be applied to a module.
        /// </summary>
        Module = 0x0002,

        /// <summary>
        /// Attribute can be applied to a class.
        /// </summary>
        Class = 0x0004,

        /// <summary>
        /// Attribute can be applied to a value type.
        /// </summary>
        Struct = 0x0008,

        /// <summary>
        /// Attribute can be applied to an enumeration.
        /// </summary>
        Enum = 0x0010,

        /// <summary>
        /// Attribute can be applied to a constructor.
        /// </summary>
        Constructor = 0x0020,

        /// <summary>
        /// Attribute can be applied to a method.
        /// </summary>
        Method = 0x0040,

        /// <summary>
        /// Attribute can be applied to a property.
        /// </summary>
        Property = 0x0080,

        /// <summary>
        /// Attribute can be applied to a field.
        /// </summary>
        Field = 0x0100,

        /// <summary>
        /// Attribute can be applied to an event.
        /// </summary>
        Event = 0x0200,

        /// <summary>
        /// Attribute can be applied to an interface.
        /// </summary>
        Interface = 0x0400,

        /// <summary>
        /// Attribute can be applied to a parameter.
        /// </summary>
        Parameter = 0x0800,

        /// <summary>
        /// Attribute can be applied to a delegate.
        /// </summary>
        Delegate = 0x1000,

        /// <summary>
        /// Attribute can be applied to a return value.
        /// </summary>
        ReturnValue = 0x2000,

        /// <summary>
        /// Attribute can be applied to a generic parameter.
        /// </summary>
        GenericParameter = 0x4000,

        /// <summary>
        /// Attribute can be applied to any element.
        /// </summary>
        All = 0x7FFF
    }
}


