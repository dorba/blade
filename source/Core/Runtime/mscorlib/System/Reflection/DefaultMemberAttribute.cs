
namespace System.Reflection
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class DefaultMemberAttribute : Attribute
	{
		private string m_memberName;

		public string MemberName
		{
			get
			{
				return this.m_memberName;
			}
		}

		public DefaultMemberAttribute(string memberName)
		{
			this.m_memberName = memberName;
		}
	}
}


