using System.Collections.Generic;

namespace EdmundsApiSDK
{
	public class Make
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string NiceName { get; set; }
		public IEnumerable<Model> models { get; set; }
	}
}
