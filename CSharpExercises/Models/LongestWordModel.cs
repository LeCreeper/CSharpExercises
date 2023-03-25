namespace CSharpExercises.Models
{
    internal class LongestWordModel
    {
        public string Word { get; set; }
        public int WordLength { get; set; }

        public LongestWordModel(string word, int wordLength)
        {
            Word = word;
            WordLength = wordLength;
        }
    }
}