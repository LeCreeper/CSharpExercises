using CSharpExercises.Models;

namespace CSharpExercises.Services.Interfaces
{
    internal interface IStringService
    {
        public LongestWordModel FindLongestWordInSentence(string sentence);
        public string ReverseString(string inputString);
        string NumberOfWordsInASentence(string inputString);
    }
}
