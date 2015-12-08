using System.Collections.Generic;

namespace EdmundsApiSDK
{
	public class CarDataDTO<T>
	{
		public IEnumerable<T> Data { get; set; }
		public int Count { get; set; }
	}
}
