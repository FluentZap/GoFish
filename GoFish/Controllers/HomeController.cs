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

      return View();
    }

  }
}
