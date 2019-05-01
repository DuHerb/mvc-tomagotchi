using System.IO;
using Microsoft.AspNetCore.Hosting;
using TamagotchiFarm.Models;


namespace TamagotchiFarm
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

      Update newUpdate = new Update();
      host.Run();
    }
  }
}
