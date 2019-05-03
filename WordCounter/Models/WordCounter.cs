using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        // Here we declare the private static string and int so we can store the information in one location.
        private static string _inputWord;
        private static string _inputSentence;
        private static int _finalResult;

        // Here we put the private strings and int into something that can be read by other aspects of our file down the line.
        public RepeatCounter (string inputWord, string inputSentence, int finalResult)
        {
            _inputWord = inputWord;
            _inputSentence = inputSentence;
            _finalResult = finalResult;
        }
        //  This set here is added in order to return the inputted word, sentence and count.  We use this in our front facing layout.  I believe individual public static strings are required to call on each of our inputs.
        public static string GetInputWord()
        {
          return _inputWord;
        }
        public static string GetInputSentence()
        {
          return _inputSentence;
        }
        public static int GetFinalResult()
        {
          return _finalResult;
        }
        // This is the core of our functionality
        public int LookUp (string inputWord, string inputSentence)
        {
            // We take the inputted sentence and drop it into an empty string where we can split it at the designated symbols.
            string[] sentenceArray = inputSentence.ToLower().Split(' ', '.', ',', '!', '?');
            // We run the length of the new array which we previously split.
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                // We take the input word and drop it to lower to process.  Then we look for the word in the split sentence.
                if (inputWord.ToLower() == sentenceArray[i])
                {
                    // This adds to our counter so we know how many instances of the word were found.
                    _finalResult++;
                }
            }
            //  We finally return the result.
            return _finalResult;
        }

    }
}
