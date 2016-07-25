using System.Collections.Generic;

namespace ScrabbleKata.Interfaces
{
    public interface IDictionaryService
    {
        bool IsInDictionary(string candidate);
        List<string> GetWords();
    }
}
