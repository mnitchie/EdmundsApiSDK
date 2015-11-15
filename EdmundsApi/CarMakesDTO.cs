using System.Collections.Generic;

namespace EdmundsApiSDK
{
	public class CarMakesDTO
	{
		public IEnumerable<Make> Makes { get; set; }
		public int MakesCount { get; set; }
	}
}
