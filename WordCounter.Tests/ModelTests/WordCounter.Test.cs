using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter;

namespace WordCounter.TestTools
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void  CountTheNumberOfWords_InputWord_ReturnWordCount()
        {
            Word newWord = new Word();
            newWord.SetWord("hello");
            Assert.AreEqual(1, newWord.CountWords());
        }
    }
}