
namespace System.Runtime.InteropServices
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false), ComVisible(true)]
    public sealed class GuidAttribute : Attribute
	{
		internal string _val;

		public string Value
		{
			get
			{
				return this._val;
			}
		}

		public GuidAttribute(string guid)
		{
			this._val = guid;
		}
	}
}


