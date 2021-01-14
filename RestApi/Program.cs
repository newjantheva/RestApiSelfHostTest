using RestApi.Helpers;
using System;
using System.Net.Http;
using System.Web.Http.SelfHost;

namespace RestApi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:1234");

            var server = new HttpSelfHostServer(config, new WebAPIMessageHandler());
            var task = server.OpenAsync();
            task.Wait();

            Console.WriteLine("Web API Server has started at http://localhost:1234");
            Console.ReadLine();
        }
    }
}
