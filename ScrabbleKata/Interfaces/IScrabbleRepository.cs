using System.Collections.Generic;

namespace ScrabbleKata.Interfaces
{
    public interface IScrabbleRepository
    {
        List<string> GetWords();
    }
}
