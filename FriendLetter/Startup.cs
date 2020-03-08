using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// standard practice to use a namespace with sam ename aas file project
namespace FriendLetter
{
  public class Startup
  {
    // create an iteration of the Startup class that contains specific settings and variables to run our project
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }
    // This line is the process of adding custom configurations to our project
    public IConfigurationRoot Configuration { get; }

    // continue configuring.. ConfigureServices() is required built-in method used to set up an application's server. We can use it to configure other framework services.
    public void ConfigureServices(IServiceCollection services)
    {
      // services.AddMvc() adds the MVC service to the project
      services.AddMvc();
    }

    // add one last required method called Configure().. ASP.NET calls Configure() when the app launches
    // states which area of our application should load by default when it launches
    public void Configure(IApplicationBuilder app)
    {
      // tells our app to use the MVC framework to respond to HTTP requests.
      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
          // ^ tells the project to use the Index action of the Home Controller as the default route.
      });

      //  not actually required to successfully launch our project.
      // allow us to test that our Configure() method is working properly.
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World!");
      });
    }
  }
}