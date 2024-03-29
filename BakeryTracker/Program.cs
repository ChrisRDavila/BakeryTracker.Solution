using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BakeryTracker.Models;

namespace BakeryTracker
{
  class Program
  {
    static void Main(string[] args)
    {

      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();

      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.MapControllerRoute(
          name: "default",
          pattern: "{controller=Splash}/{action=Index}/{id?}");

      app.Run();
    }
  }
}
