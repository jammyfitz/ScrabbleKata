using System.Collections.Generic;
using ScrabbleKata.Interfaces;
using ScrabbleKata.Repositories;

namespace ScrabbleKata.Services
{
    public class DictionaryService : IDictionaryService
    {
        private readonly ScrabbleRepository _scrabbleRepository;
        private readonly List<string> _words;

        public DictionaryService()
        {
           _scrabbleRepository = new ScrabbleRepository();
            _words = GetWords();
        }

        public List<string> GetWords()
        {
            return _scrabbleRepository.GetWords();
        }

        public bool IsInDictionary(string candidate)
        {
            return _words.Contains(candidate);
        }
    }
}
