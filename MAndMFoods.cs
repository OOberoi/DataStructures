using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    public static class MAndMFoods
    {
        public static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public static bool IsStringValid(char[] someValue)
        {
            int x = 0;
            int y = someValue.Length - 1;

            while (true)
            {
                if (x > y)
                {
                    return true;
                }
                char a = someValue[x];
                char b = someValue[y];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                x++;
                y--;
            }
        }

        public static bool CompareArrays(string[] arrA, string[] arrB)
        {
            bool IsEqual = arrA.SequenceEqual(arrB);
            return IsEqual;
        }

        public static string[] DifferArrays(string[] arrA, string[] arrB)
        {
            string[] diffArr = arrA.Except(arrB).ToArray();
            return diffArr;
        }

        public static bool CheckProjectDedpendency()
        {
            string[] list1 = { "p7", "p1" };
            string[] list2 = { "p8", "p17", "p10" };
            string[] arr = list1.Intersect(list2).ToArray();

            if (arr.Length == 0)
            {
                return true;
            }
            return false;
        }

    }
}
