using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            var maxLen = 3;
            var line = new ChoosingInput();
            var words = new ArrayOfString(line.Line);
            Console.WriteLine("The array of strings is:");
            PrintArray(words.Words);
            var wordsShort = RemoveShortWordsFromArray(words.Words, maxLen);
            Console.WriteLine("The array of words with length {0} or less charackters is: ",maxLen);
            PrintArray(wordsShort);
        }
        static string[] RemoveShortWordsFromArray(string[] words, int len) => words
            .Where(n=>(n.Length<=len))
            .ToArray();
        static void PrintArray(string[] arr) => Console.WriteLine(string.Join(" ",arr));
    }
    class ArrayOfString
    {
        public string[] Words {get;init;}
        public ArrayOfString(string line)
        {
            this.Words = ArrayFromString(line);
        }
        static string[] ArrayFromString(string line) => line
            .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    }
}