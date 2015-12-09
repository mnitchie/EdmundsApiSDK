using System.Collections.Generic;

namespace EdmundsApiSDK
{
	public class CarMakeDTO
	{
		public IEnumerable<Make> Makes { get; set; }
		public int Count { get; set; }
	}
}
