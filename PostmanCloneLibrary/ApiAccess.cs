using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
	public class ApiAccess
	{
		private readonly HttpClient _client = new();
     
        public async Task<string> CallApiAsync(
									string url, 
									bool formatOutput = true, 
									HttpAction action = HttpAction.GET)
		{
			var response = await _client.GetAsync(url);

			if (response.IsSuccessStatusCode == false)
			{
				return $"Error: {response.StatusCode}";
			}
			string json = await response.Content.ReadAsStringAsync();

			if(formatOutput )
			{
				var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
				json = JsonSerializer.Serialize(jsonElement, 
						new JsonSerializerOptions {WriteIndented = true });
			}

			return json;
		}

		public bool IsValidUrl(string url)
		{
			if (string.IsNullOrEmpty(url)) return false;

			bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput)
							&& (uriOutput.Scheme == Uri.UriSchemeHttps);
			return output;
		}
	}

	
}
