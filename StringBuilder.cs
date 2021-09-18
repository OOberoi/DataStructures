using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class StringBuilderNew

    {
        public static string BuildAString()
        {
            StringBuilder sb = new StringBuilder("MaxCapacity", 100);
            sb.Append("Hello Obi!");
            sb.Append("This is fun!");

            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }
            return sb.ToString();
        }
    }
}
