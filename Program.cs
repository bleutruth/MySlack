using System;
using System.Text;
using System.Net.Http;

namespace MySlack
{
	class Program
	{
		static int Main(string[] args)
		{
			if (args.Length <= 0)
			{
				Console.WriteLine("URIを引数で渡してください。");
				return -1;
			}
			var uri = args[0];

			var hc = new HttpClient();
			var content = new StringContent("{\"text\": \"test\"}", Encoding.UTF8, "application/json");
			HttpResponseMessage res = null;
			try
			{
				res = hc.PostAsync(uri, content).Result;
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
