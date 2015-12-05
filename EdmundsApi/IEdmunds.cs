using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdmundsApiSDK
{
	public interface IEdmunds
	{
		Task<IEnumerable<Make>> GetMakes(string year = null);
	}
}
