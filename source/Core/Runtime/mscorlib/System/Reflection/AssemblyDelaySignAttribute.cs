
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyDelaySignAttribute : Attribute
    {
        private bool _delaySign;
        public bool DelaySign
        {
            get
            {
                return this._delaySign;
            }
        }
        public AssemblyDelaySignAttribute(bool delaySign)
        {
            this._delaySign = delaySign;
        }
    }
}


