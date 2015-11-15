using System.Collections.Generic;

namespace EdmundsApiSDK
{
	public class Model
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string NiceName { get; set; }
		public IEnumerable<string> States { get; set; }
		public IEnumerable<CarYear> Years { get; set; }
	}
}
