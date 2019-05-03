using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    // Passed: This test method uses something called IsInstanceOfType.  This makes sure that the specified object is an instance of the current type.  We specifically want to make sure View is the returned instance of Index. (Making sure that the HomeController does its job)
    [TestMethod]
    public void Index()
    {
      HomeController homeController = new HomeController();
      ActionResult matchIndex = homeController.Index();
      Assert.IsInstanceOfType(matchIndex, typeof(ViewResult));
    }
  }
}
