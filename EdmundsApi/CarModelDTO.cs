using System.Collections.Generic;

namespace EdmundsApiSDK
{
	class CarModelDTO
	{
		public IEnumerable<Model> Models { get; set; }
		public int Count { get; set; }
	}
}
