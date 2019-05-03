using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
      // This is our landing page
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
