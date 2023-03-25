using CSharpExercises.Services.Interfaces;

namespace CSharpExercises
{
    internal class Problems
    {
        private readonly IWordService _wordService;

        public Problems(IWordService wordService)
        {
            _wordService = wordService;
        }

        internal void LongestWordInASentenceProblem()
        {
            var inputString = "Write a C# Sharp Program to display the following pattern using the alphabetical";

            Console.WriteLine($"Problem: Find longest word in given sentence: \n{inputString}.\n");

            var longestWordModel = _wordService.FindLongestWordInSentence(inputString);

            Console.WriteLine($"Solution: The longest word is {longestWordModel.Word}, with a length of {longestWordModel.WordLength} letters.");

            Console.WriteLine("\nPress any button to return to the menu.");
            Console.ReadLine();
        }

        internal void ReverseStringProblem()
        {
            var inputString = "Write a C# Sharp Program to display the following pattern using the alphabet";
            Console.WriteLine($"Problem: Reverse a given string: \n{inputString}.\n");
            var reversedString = _wordService.ReverseString(inputString);
            Console.WriteLine($"Solution: The reversed string is: \n{reversedString}.");
            Console.WriteLine("\nPress any button to return to the menu.");
            Console.ReadLine();
        }
    }
}