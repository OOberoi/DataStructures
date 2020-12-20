using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Arrays
{
    public static class BinaryGap
    {
        /// <summary>
        /// test
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FindBinaryGap(int n)
        {
            var binary = Convert.ToString(n, 2);
            var regex = new Regex("(?<=1)(0+)(?=1)");

            int retVal = regex.Matches(binary)
                .Cast<Match>()
                .Select(b => b.Length)
                .DefaultIfEmpty(0)
                .Max();

            return retVal;
        }
    }
}
