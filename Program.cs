using System;
using System.IO;
using Alexandria.Books;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Alexandria {
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

    class Startup     {
    	public void ConfigureServices(IServiceCollection services) 	    {
            services.AddMvc();
    	    services.AddSingleton<BooksRepository, InMemoryBooksRepository>();
    	}

	    public void Configure(IApplicationBuilder app, IHostingEnvironment env) 	    {
	    	app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
	        app.UseMvc();
	    }
    }
}
