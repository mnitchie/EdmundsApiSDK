using System.Collections.Generic;
using System.Threading.Tasks;

namespace EdmundsApiSDK
{
	public interface IEdmunds
	{
		Task<IEnumerable<Make>> GetMakes(string year = null);
		Task<Make> GetMakeByNiceName( string niceName );
		Task<IEnumerable<Model>> GetModelsByMake( string makeNiceName, string year = null );
	}
}
