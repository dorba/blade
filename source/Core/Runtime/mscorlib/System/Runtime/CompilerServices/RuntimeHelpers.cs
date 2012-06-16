
using System.Reflection;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// For compiler compatibility.
    /// Not for use within blade.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class RuntimeHelpers
    {
        public static void InitializeArray(Array array, RuntimeFieldHandle handle)
        {
        }
    }
}
