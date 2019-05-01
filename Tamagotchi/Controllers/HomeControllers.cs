using Microsoft.AspNetCore.Mvc;

namespace TamagotchiFarm.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
