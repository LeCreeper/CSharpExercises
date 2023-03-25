using CSharpExercises.Models;

namespace CSharpExercises.Services.Interfaces
{
    internal interface IWordService
    {
        public LongestWordModel FindLongestWordInSentence(string sentence);
        public string ReverseString(string inputString);
    }
}
