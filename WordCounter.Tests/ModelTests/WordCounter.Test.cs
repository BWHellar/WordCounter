using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter;

namespace WordCounter.Test
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        // Passed
        public void CheckingWordAsString_InputHello_OutputTrue()
        {
            string inputWord = "Hello";
            bool result = inputWord is string;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        // Passed
        public void CheckingSentenceAsString_InputThisIsASentence_OutputTrue()
        {
            string inputSentence = "This is a Sentence";
            bool result = inputSentence is string;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        // Results in warning CS0183 - Given expression is always of the privided 'int. Still passes
        public void CheckingFinalResultIsInt_Input1_OutputTrue()
        {
            int finalResult = 1;
            bool result = finalResult is int;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        // Passed
        public void CheckingIfWordsAreInSentence_InputThisIsASentence_Output1()
        {
            int finalResult = 0;
            string inputSentence = "This is a Sentence";
            string inputWord = "Sentence";
            RepeatCounter count = new RepeatCounter (inputWord, inputSentence, finalResult);
            Assert.AreEqual(1, count.LookUp(inputWord, inputSentence));
        }
        [TestMethod]
        public void CheckingVariousFormsOfWords_
    }
}