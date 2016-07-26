using System;
using System.Collections.Generic;

namespace ScrabbleKata.Services
{
    public class PermutatorService
    {
        private static List<char[]> _candidateList { get; set; }

        public static List<string> GetPermutations(char[] list)
        {
            _candidateList = new List<char[]>();

            int x = list.Length - 1;
            GetPer(list, 0, x);

            var stringCandidateList = new List<string>();

            foreach (char[] candidate in _candidateList)
            {
                stringCandidateList.Add(new string(candidate));
            }

            return stringCandidateList;
        }

        #region Private Methods
        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                string tempEntry = new string(list);

                _candidateList.Add(tempEntry.ToCharArray());

                tempEntry = null;
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }


        #endregion
    }

}
