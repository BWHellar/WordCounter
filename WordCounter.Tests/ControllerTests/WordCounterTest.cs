using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    // Passed: This test method uses something called IsInstanceOfType.  This makes sure that the specified object is an instance of the current type.  We specifically want to make sure View is the returned instance of Index. (Making sure that the WordCounterController does its job)
    [TestMethod]
    public void Index()
    {
    WordCounterController wordController = new WordCounterController();
    ActionResult matchIndex = wordController.Index();
    Assert.IsInstanceOfType(matchIndex, typeof(ViewResult));
    }
    // Passed: This test method looks to check if this will return the right result.  This is done in order to see if the new controller properly functions with our WordCounter. 
    [TestMethod]
    public void CreateCount()
    {
      WordCounterController wordController = new WordCounterController();
      RedirectToActionResult testResult = wordController.CreateCount("Word","Word Wordword word", 2) as RedirectToActionResult;
      string result = testResult.ActionName;
      Assert.AreEqual(result, "Index");
    }
  }
}
