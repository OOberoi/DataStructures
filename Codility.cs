using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    public static class Codility
    {
        //Test Case 1
        public static int TestCase1Original(int[] A)
        {
            int ans = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < ans)
                {
                    ans = A[i];
                }
            }
            return ans;
        }

        public static int TestCase1Modified(int[] A)
        {
            var ans = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray().Last();
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < ans)
                {
                    ans = A[i];
                }
            }
            return ans;
        }


        //given an array of numbers, find a number that does not have a pair
        public static int FindUpaired(int[] pairsArr)
        {
            int unpairedNum = 0;
            for (int i = 0; i < pairsArr.Length; i++)
            {
                unpairedNum ^= pairsArr[i];
            }
            return unpairedNum;
        }

        public static int FindUpairedLINQ(int[] pairsArr)
        {
            return pairsArr.Aggregate(0, (x, y) => x ^= y);
        }

        public static int FrogJump(int x, int y, int z)
        {
            int distToJump = y - x;
            int jumpRequired = distToJump / z;

            if (distToJump % z != 0)
            {
                jumpRequired++;
            }
            return jumpRequired;
        }

        public static int MySolution(int[] A)
        {
            //1,3,6,4,1,2 (for viewing only)
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int prev = 0;

            var positives = A.Where(x => x > 0).Distinct().OrderBy(x => x).ToArray();
            if (positives.Count() == 0) return 1;

          
            for (int i = 0; i < positives.Count(); i++)
            {
                if (positives[i] != prev + 1)
                {
                    return prev + 1;
                }
                prev = positives[i];
            }
            return positives.Last() + 1;
        }

        public static void MissingNumbers()
        {
            var myList = new List<int>() { 1, 2, 3, 5, 8, 9 };

            Console.WriteLine("Numbers...");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            int a = myList.OrderBy(x => x).First();
            int b = myList.OrderBy(y => y).Last();

            var myList2 = Enumerable.Range(a, b - a + 1).ToList();
            var remaining = myList2.Except(myList).ToList();

            Console.WriteLine("Remaining numbers...");
            foreach (var item in remaining)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

