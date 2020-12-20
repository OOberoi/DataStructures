using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    public static class MathUtil
    {
        public static double Average(int a, int b)
        {
            return a + b / 2;
        }

        public static void GetLargestNumber(int input)
        {
            List<int> list = new List<int>();

            int AllDigits = input % 1000;
            int firstDigit = Convert.ToInt32(AllDigits.ToString().Substring(0, 1));
            list.Add(firstDigit);

            int lastTwoDigits = input % 100;
            int middleDigit = Convert.ToInt32(lastTwoDigits.ToString().Substring(0, 1));
            list.Add(middleDigit);

            int lastDigit = input % 10;
            list.Add(lastDigit);

            var sortedItems = list.OrderByDescending(x => x).ToList();

            foreach (var item in sortedItems)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }

    }
}
