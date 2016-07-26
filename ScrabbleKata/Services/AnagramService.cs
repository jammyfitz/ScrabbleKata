using System.Collections.Generic;
using System.Linq;

namespace ScrabbleKata.Services
{
    public class AnagramService
    {
        public static bool AreStringsAnagrams(string a, string b)
        {
            List<char> charListOne = a.ToCharArray().ToList();
            List<char> charListTwo = b.ToCharArray().ToList();

            if (charListOne.Count != charListTwo.Count)
            {
                return false;
            }

            foreach (char character in charListOne)
            {
                if (!charListTwo.Contains(character))
                {
                    return false;
                }

                charListTwo.Remove(character);
            }
            return true;
        }
    }
}
