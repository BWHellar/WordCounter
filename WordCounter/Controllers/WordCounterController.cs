using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
        [HttpGet("/WordCount")]
        public ActionResult Index()
        {
          return View();
        }
        [HttpGet("/WordCount/New")]
        public ActionResult CreateCount()
        {
          return View();
        }

        [HttpPost("/WordCount")]
        public ActionResult CreateCount(string inputWord, string inputSentence, int finalResult)
        {
          RepeatCounter counter = new RepeatCounter(inputWord, inputSentence, finalResult);
          counter.LookUp(inputWord, inputSentence);
          return RedirectToAction("Index", counter);
        }
  }
}
