using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace GoFish.Controllers
{
  public class GameController : Controller
  {

    [HttpGet("/game")]
    public ActionResult playerTurn()
    {
      Game g = CurrentGame.ThisGame;
      return View(g.Players[g.CurrentTurn]);
    }

    [HttpPost("/game/turn")]
    public ActionResult PickCard(int card)
    {
      Game g = CurrentGame.ThisGame;
      foreach (int otherPlayerCard in g.GetNextPlayer().Hand) {
        Card.IsTheSame(card, otherPlayerCard)

      }

      g.NextTurn();

      return RedirectToAction("playerTurn");
    }

  }
}
