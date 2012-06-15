
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public class AssemblyTrademarkAttribute : Attribute
    {
		private string _trademark;

		public string Trademark
        {
			get { return _trademark; }
        }
		public AssemblyTrademarkAttribute(string trademark)
        {
			_trademark = trademark;
        }
    }
}


