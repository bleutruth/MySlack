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
			HttpResponseMessage res = null;
			try
			{
				res = hc.PostAsync("https://XXX", content).Result;
			}
			catch (AggregateException e)
			{
				Console.WriteLine(e);
				return -1;
			}
			Console.WriteLine(res);
			return 0;
		}
	}
}
