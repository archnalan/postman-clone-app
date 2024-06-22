using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
	public interface IApiAccess
	{
		Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true);
		Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.GET, bool formatOutput = true);
		bool IsValidUrl(string url);
	}
}
