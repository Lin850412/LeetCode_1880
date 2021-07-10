using System;
using System.Collections.Generic;

namespace LeetCode_1880
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "acb";
            string secondWord = "cba";
            string targetWord = "cdb";

            var result = IsSumEqual(firstWord, secondWord, targetWord);
            Console.WriteLine(result);
        }

        public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int v1 = GetValue(firstWord);
            int v2 = GetValue(secondWord);
            int v3 = GetValue(targetWord);
            int v4 = v1 + v2;

            if (v4 == v3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetValue(string sz)
        {
            int value = 0;
            var result = Leter2Number(sz);
            var result_2 = SortNumber(result);
            var result_3 = Convert2Value(result_2);

            return result_3;
        }

        private static char[] Leter2Number( string sz )
        {
            char[] nCountArr = new char[sz.Length];
            int count = 0;
            string szFirstWord_new = String.Empty;
            char[] szLeterArr 
                = new char[10] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };


            foreach (char leter in sz)
            {
                for (int idx = 0; idx < szLeterArr.Length; idx++)
                {
                    if (leter == szLeterArr[idx])
                    {
                        nCountArr[count] = Convert.ToChar(idx);
                        count++;
                    }
                }
            }
            Console.WriteLine(nCountArr.ToString());
            
            return nCountArr;
        }

        private static List<int> SortNumber(char[] nArr)
        {
            List<int> lNumber = new List<int>();
            if ( nArr[0] == '\0')
            {
                for (int i = 1; i < nArr.Length; i++)
                {
                    lNumber.Add(Convert.ToInt32(nArr[i]));
                }
            }
            else
            {
                for (int i = 0; i < nArr.Length; i++)
                {
                    lNumber.Add(Convert.ToInt32(nArr[i]));
                }
            }
            return lNumber;
        }

        private static int Convert2Value( List<int> lst) 
        {
            double nValue = 0;
            int nCount = lst.Count;

            for (int i = 0; i < lst.Count; i++)
            {
                nValue += lst[i] * Math.Pow(10, nCount-1);
                nCount -= 1;
            }

            return Convert.ToInt32(nValue);
        }
    }
}
