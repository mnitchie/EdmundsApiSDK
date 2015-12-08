using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EdmundsApiSDK
{
	public class Edmunds : IEdmunds
	{
		private string _apiKey;
		private string _apiRoot;
		private HttpClient _client;

		public Edmunds(string apiKey)
		{
			_apiKey = apiKey;
			_apiRoot = "api/vehicle/v2/";

			_client = new HttpClient();
			_client.BaseAddress = new Uri( "http://api.edmunds.com/" );
			_client.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
		}

		public async Task<IEnumerable<Make>> GetMakes(string year = null)
		{
			IDictionary<string, string> parameters = null;
			if (year != null)
			{
				parameters = new Dictionary<string, string>();
				parameters.Add( "year", year );
			}

			HttpResponseMessage response = await _client.GetAsync( GenerateURLForResource("makes", parameters) );
			response.EnsureSuccessStatusCode();

			var responseBody = JsonConvert.DeserializeObject<CarDataDTO<Make>>( await response.Content.ReadAsStringAsync() );
			return responseBody.Data;
		}

		public async Task<IEnumerable<Model>> GetModelsByMake(string makeNiceName, string year = null)
		{
			IDictionary<string, string> parameters = null;
			

			if (year != null)
			{
				parameters = new Dictionary<string, string>();
				parameters.Add( "year", year );
			}

			HttpResponseMessage response = await _client.GetAsync( GenerateURLForResource( makeNiceName + "/models", parameters ) );
			response.EnsureSuccessStatusCode();

			var responseBody = JsonConvert.DeserializeObject<CarDataDTO<Model>>( await response.Content.ReadAsStringAsync() );
			return responseBody.Data;
		}

		private string GenerateURLForResource(string resource, IDictionary<string, string> options = null)
		{
			StringBuilder url = new StringBuilder();
			url.Append( _apiRoot );
			url.Append( resource );
			url.Append( "?" );
			url.Append( "api_key=" + _apiKey );
			
			if (options != null)
			{
				url.Append( "&" );
				url.Append( string.Join( "&", options.Select( entry => entry.Key + "=" + entry.Value ).ToArray() ) );
			}

			return url.ToString();
		}
	}
}
