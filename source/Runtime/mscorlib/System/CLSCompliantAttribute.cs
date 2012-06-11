
namespace System
{
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
