using Microsoft.AspNetCore.Mvc;



namespace BakeryTracker.Controllers
{
  public class SplashController : Controller
  {
    [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
  }
}