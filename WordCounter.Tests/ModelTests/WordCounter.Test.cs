using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter;

namespace WordCounter.Test
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        // Passed: Checking to see if string of inputWord registers as a string.
        public void CheckingWordAsString_InputHello_OutputTrue()
        {
            string inputWord = "Hello";
            bool result = inputWord is string;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        // Passed: Checking to see if string of inputSentence registers as a string.
        public void CheckingSentenceAsString_InputThisIsASentence_OutputTrue()
        {
            string inputSentence = "This is a Sentence";
            bool result = inputSentence is string;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        // Passed: Registers a warning as int is an int: Checking to see if the int finalResult registers as an int.
        public void CheckingFinalResultIsInt_Input1_OutputTrue()
        {
            int finalResult = 1;
            bool result = finalResult is int;
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        // Passed: Checking to see if program registers one instance of the word "Sentence" in sentence.
        public void CheckingIfWordsAreInSentence_InputThisIsASentence_Output1()
        {
            int finalResult = 0;
            string inputSentence = "This is a Sentence";
            string inputWord = "Sentence";
            RepeatCounter count = new RepeatCounter (inputWord, inputSentence, finalResult);
            Assert.AreEqual(1, count.LookUp(inputWord, inputSentence));
        }
        [TestMethod]
        // Passed: Checking to see if program registers two instances of "Hat" and ignores the word of "HatHat".
        public void CheckingVariousFormsOfWords_InputHatHat_Hat_Hat_Ouput2()
        {
            int finalResult = 0;
            string inputSentence = "HatHat Hat hat";
            string inputWord = "Hat";
            RepeatCounter count = new RepeatCounter (inputWord, inputSentence, finalResult);
            Assert.AreEqual(2, count.LookUp(inputWord, inputSentence));
        }
        [TestMethod]
        // Passed: Checking to see if program registers four instances of "Dog" and properly separates sentence ending symbols.
        public void CheckingNonSpaces_InputWordsAndSymbols_OutputCorrectWordCount()
        {
            int finalResult = 0;
            string inputSentence = "dog $ Dogdog Dog*@($% dog&&Dog dog !dog Dog!";
            string inputWord = "Dog";
            RepeatCounter count = new RepeatCounter (inputWord, inputSentence, finalResult);
            Assert.AreEqual(4, count.LookUp(inputWord, inputSentence));
        }
    }
}