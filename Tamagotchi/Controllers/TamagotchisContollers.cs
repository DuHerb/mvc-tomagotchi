using Microsoft.AspNetCore.Mvc;
using TamagotchiFarm.Models;
using System.Collections.Generic;


namespace TamagotchiFarm.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View(allTamagotchis);
    }

    [HttpGet("/tamagotchis/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchis")]
    public ActionResult Create(string name)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/tamagotchis/{id}")]
    public ActionResult Show(int id)
    {
      Tamagotchi tamagotchis = Tamagotchi.Find(id);
      return View(tamagotchis);
    }

    [HttpPost("/tamagotchis/time")]
    public ActionResult Update()
    {
      Tamagotchi.MoveTime();
      return RedirectToAction("Index");
    }
    [HttpPost("/tamagotchis/food/{id}")]
    public ActionResult UpdateFood(int id)
    {
      Tamagotchi.Feed(id);
      return RedirectToAction("Show");
    }
    [HttpPost("/tamagotchis/health/{id}")]
    public ActionResult UpdateHealth(int id)
    {
      Tamagotchi.Heal(id);
      return RedirectToAction("Show");
    }
    [HttpPost("/tamagotchis/attention/{id}")]
    public ActionResult UpdateAttention(int id)
    {
      Tamagotchi.Love(id);
      return RedirectToAction("Show");
    }
    [HttpPost("/tamagotchis/rest/{id}")]
    public ActionResult UpdateRest(int id)
    {
      Tamagotchi.Sleep(id);
      return RedirectToAction("Show");
    }
  }
}
