using System;
using System.Collections.Generic;
using System.Linq;
using ScrabbleKata.Extensions;
using ScrabbleKata.Interfaces;

namespace ScrabbleKata.Services
{
    public class ScrabbleService : IScrabbleService
    {
        private readonly DictionaryService _dictionaryService;

        public ScrabbleService()
        {
            _dictionaryService = new DictionaryService();
        }
        public string GetLongestWord(char[] chars)
        {
            var candidateList = GetCandidateListOfWords(chars);

            candidateList = GetValidWords(candidateList);

            return candidateList.GetLongestItem();
        }

        #region Private
        private List<string> GetCandidateListOfWords(char[] chars)
        {
            return PermutatorService.GetPermutations(chars);
        }

        private List<string> GetValidWords(List<string> candidateList)
        {
            var validWords = new List<string>();

            foreach (var candidate in candidateList)
            {
                if (IsInDictionary(candidate))
                {
                    validWords.Add(candidate);
                }
            }

            return validWords;
        }

        private bool IsInDictionary(string candidate)
        {
            return _dictionaryService.IsInDictionary(candidate);
        }
        #endregion
    }
}
