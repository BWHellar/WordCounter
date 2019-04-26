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
        public int LookUp (string inputWord, string inputSentence)
        {
            string[] sentenceArray = inputSentence.ToLower().Split(' ', '.', ',', '!', '?', '(', ')', '/');
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (inputWord.ToLower() == sentenceArray[i])
                {
                    _finalResult++;
                }
            }
            return _finalResult;
        }
    }
}