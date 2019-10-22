using System;
using System.Net.Http;

namespace MySlack
{
	class Program
	{
		static int Main(string[] args)
		{
			var hc = new HttpClient();
			HttpContent content = null;
			var res = hc.PostAsync("https://XXX", content).Result;
			Console.WriteLine(res);
			return 0;
		}
	}
}
