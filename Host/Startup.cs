using Alexandria.Books;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Alexandria.Host
{
    class Startup {
        public void ConfigureServices(IServiceCollection services) 	    {
            services.AddMvc();
            //services.AddSingleton<BooksRepository, InMemoryBooksRepository>();
            services.AddSingleton<BooksRepository, DatabaseBooksRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) 	    {
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseMvc();
        }
    }
}