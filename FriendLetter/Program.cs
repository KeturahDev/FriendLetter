using System.IO;
using Microsoft.AspNetCore.Hosting;

// both Startup.cs and Program.cs files contain code in the same FriendLetter namespace. This ensures the code blocks in Startup.cs and Program.cs have access to each other.
namespace FriendLetter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}