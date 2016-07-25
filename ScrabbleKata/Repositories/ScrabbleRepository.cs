using System.Collections.Generic;
using System.IO;
using System.Linq;
using ScrabbleKata.Interfaces;

namespace ScrabbleKata.Repositories
{
    public class ScrabbleRepository : IScrabbleRepository
    {
        public List<string> GetWords()
        {
            return File.ReadAllLines(@"C:\repos\ScrabbleKata\ScrabbleKata\ScrabbleKata\Resources\Dictionary.txt").ToList();
        }
    }
}
