using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
        // This portion will give us the Index view when we are at the http extension of /WordCount.
        [HttpGet("/WordCount")]
        public ActionResult Index()
        {
          return View();
        }
        // This portion will give us a new entry sheet to write on when we are at the /WordCount/New extension.
        [HttpGet("/WordCount/New")]
        public ActionResult CreateCount()
        {
          return View();
        }
        // This portion will allow us to Post (or carry the request data) what we input.  Makes sure our CreateCount carries that requested data to our view location with is /WordCount.
        [HttpPost("/WordCount")]
        public ActionResult CreateCount(string inputWord, string inputSentence, int finalResult)
        {
          RepeatCounter counter = new RepeatCounter(inputWord, inputSentence, finalResult);
          counter.LookUp(inputWord, inputSentence);
          return RedirectToAction("Index", counter);
        }
  }
}
