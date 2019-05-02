using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace GoFish.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Game g = CurrentGame.ThisGame;
      //CurrentGame.ThisGame.Players[0].Hand
      Console.WriteLine(g.Players[g.CurrentTurn].Name);
      return View(g.Players[g.CurrentTurn]);
    }

  }
}
