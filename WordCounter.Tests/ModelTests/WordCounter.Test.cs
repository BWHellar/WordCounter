using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter;

namespace WordCounter.Test
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void CheckingWordAsString_InputHello_OutputTrue()
        {
            string inputWord = "Hello";
            bool result = inputWord is string;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void CheckingSentenceAsString_InputThisIsASentence_OutputTrue()
        {
            string inputSentence = "This is a Sentence";
            bool result = inputSentence is string;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void CheckingFinalResultIsInt()
    }
}