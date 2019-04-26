using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private static string _inputWord;
        private static string _inputSentence;
        private static int _finalResult;

        public RepeatCounter (string inputWord, string inputSentence, int finalResult)
        {
            _inputWord = inputWord;
            _inputSentence = inputSentence;
            _finalResult = finalResult;
        }
        // public int LookUp (string inputWord, string inputSentence)
    }
}