using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Alexandria.Host {
    public class Program     {
        public static void Main(string[] args)         {
            string contentRoot = Directory.GetCurrentDirectory();
            const string webRoot = "st";
            string[] urls = { "http://*:10000", "http://*:10001" };

            Console.WriteLine($"URLs: {urls}. ContentRoot: {contentRoot}. WebRoot: {webRoot}");
            
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls(urls)
                .UseContentRoot(contentRoot)
                .UseWebRoot(webRoot)
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
