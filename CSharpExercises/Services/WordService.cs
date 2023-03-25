using CSharpExercises.Models;
using CSharpExercises.Services.Interfaces;

namespace CSharpExercises.Services
{
    internal class WordService : IWordService
    {
        public LongestWordModel FindLongestWordInSentence(string sentence)
        {
            var words = sentence.Split(' ');

            var longestWord = "";
            var previousLongestWordLength = 0;

            foreach (var currentWord in words)
            {
                if (currentWord.Length > previousLongestWordLength)
                {
                    longestWord = currentWord;
                    previousLongestWordLength = currentWord.Length;
                }
            }

            return new LongestWordModel(longestWord, previousLongestWordLength);
        }

        public string ReverseString(string inputString)
        {
            var reversedString = "";
            for (var i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }
            return reversedString;
        }
    }
}