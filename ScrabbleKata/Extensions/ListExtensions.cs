using System.Collections.Generic;
using System.Linq;

namespace ScrabbleKata.Extensions
{
    public static class ListExtensions
    {
        public static string GetLongestItem(this List<string> list)
        {
            return list.OrderBy(x => x.Length).LastOrDefault();
        }
    }
}
