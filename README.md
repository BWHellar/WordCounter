# Word Counter

#### This project will count the number of times a word appears, April/26/2019


#### By _**Brendan Hellar**_

## Description


#### This project will showcase our introductory knowledge of C#.  The primary focus of this project is about utilizing testing in our projects.  This program will focus on our ability to test basic functions which will be useful in larger scale testing environments.

## Specs
| Spec | Input | Output | Reasoning |
| :-------------     | :------------- | :------------- | :----------- |
| **Allows Input of Words** | User input: "cookie" | Output: "1" | Reasoning: The inputted word was "cookie" and the program counted one instance of "cookie". |
| **Counts Instances of Words in Sentence** | User Input: "This is a cookie" | Output: "1" | Reasoning: The program searched the sentence and found one instance of "cookie". |
| **Accounts for sentence ending symbols** | User Input: "This cookie is a cookie!" | Output: "2" | Reasoning: The program found two instances of "cookie" as it designated "!" as a proper sentencer ender |
| **Avoids instances of word in other words** | User Input: "This cookiehat is a cookie" | Output: "1" | Reasoning: The program found one instance of "cookie" as it determined that "cookiehat" was a completely new word |

###### Here we declare the private static string and int so we can store the information in one location.  Then we put the private strings and int into something that can be read by other aspects of our file down the line.
```
        private static string _inputWord;
        private static string _inputSentence;
        private static int _finalResult;

        public RepeatCounter (string inputWord, string inputSentence, int finalResult)
        {
            _inputWord = inputWord;
            _inputSentence = inputSentence;
            _finalResult = finalResult;
        }
 ```
 ###### We take the inputted sentence and drop it into an empty string where we can split it at the designated symbols. We run the length of the new array which we previously split.  We take the input word and drop it to lower to process.  Then we look for the word in the split sentence.This adds to our counter so we know how many instances of the word were found.  Lastly we finally return the result.
 ```
        public int LookUp (string inputWord, string inputSentence)
        {
            string[] sentenceArray = inputSentence.ToLower().Split(' ', '.', ',', '!', '?');
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                if (inputWord.ToLower() == sentenceArray[i])
                {
                    _finalResult++;
                }
            }
            return _finalResult;
        }
=======
```
## Setup/Installation Requirements

Download .NET Core 2.2.103 SDK install it. Download Mono and install it.

1. Clone this repository: $ git clone repo name
2. Change into the work directory:: $ cd WordCounter.Solution
3. To edit the project, open the project in your preferred text editor.

 - To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $ cd                WordCounter/Models $ mcs WordCounter.cs; mono WordCounter.exe;

 - To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test

## Known Bugs

No known bugs

## Support and contact details

If you have any issues please contact Brendan Hellar at bwhellar@gmail.com

## Technologies Used

C#

### License

MIT

Copyright (c) 2019 **Brendan Hellar**
