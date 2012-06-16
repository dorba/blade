
using System.Reflection;

namespace System.Runtime.InteropServices
{
    /// <summary>
    /// For project compatibility.
    /// Not for use within blade.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
        AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false), ComVisible(true)]
	public sealed class ComVisibleAttribute : Attribute
	{
		internal bool _val;

		public bool Value
		{
			get
			{
				return this._val;
			}
		}

		public ComVisibleAttribute(bool visibility)
		{
			this._val = visibility;
		}
	}
}


