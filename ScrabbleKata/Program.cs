using System;
using ScrabbleKata.Services;

namespace ScrabbleKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var scrabbleService = new ScrabbleService();

            Console.WriteLine("Please enter your 7 letters:");

            var userInput = Console.ReadLine();

            var longestWord = scrabbleService.GetLongestWord(userInput.ToCharArray());

            if (!string.IsNullOrEmpty(longestWord))
            {
                Console.WriteLine("Longest Match Found: " + longestWord);
            }
            else
            {
                Console.WriteLine("No Match Found");
            }

            Console.ReadLine();
        }
    }
}
