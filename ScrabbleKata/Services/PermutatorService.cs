using System;
using System.Collections.Generic;

namespace ScrabbleKata.Services
{
    public class PermutatorService
    {
        public static List<char[]> CandidateList { get; set; }

        public PermutatorService()
        {
            CandidateList = new List<char[]>();
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }
        public void GetPer2(char[] list)
        {
            int x = list.Length - 1;
            GetPer2(list, 0, x);
        }

        public static List<string> GetPermutations(char[] list)
        {
            CandidateList = new List<char[]>();

            int x = list.Length - 1;
            GetPer2(list, 0, x);

            var stringCandidateList = new List<string>();

            foreach (char[] candidate in CandidateList)
            {
                stringCandidateList.Add(new string(candidate));
            }

            return stringCandidateList;
        }

        #region Private Methods
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.Write(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        private static void GetPer2(char[] list, int k, int m)
        {
            if (k == m)
            {
                string tempEntry = new string(list);

                CandidateList.Add(tempEntry.ToCharArray());

                tempEntry = null;
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer2(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        #endregion
    }

}
