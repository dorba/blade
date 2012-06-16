
using System.Reflection;

namespace System
{
    /// <summary>
    /// Indicates whether a program element is compliant with the Common Language Specification (CLS). This class cannot be inherited.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public sealed class CLSCompliantAttribute : Attribute
    {
        private bool _isCompliant;
        public bool IsCompliant
        {
            get
            {
                return this._isCompliant;
            }
        }
        public CLSCompliantAttribute(bool isCompliant)
        {
            this._isCompliant = isCompliant;
        }
    }
}
