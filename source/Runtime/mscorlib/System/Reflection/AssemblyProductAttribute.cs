
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public class AssemblyProductAttribute : Attribute
    {
        private string _product;

        public string Product
        {
            get { return _product; }
        }
        public AssemblyProductAttribute(string product)
        {
            _product = product;
        }
    }
}


