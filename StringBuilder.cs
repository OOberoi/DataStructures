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
            sb.AppendLine();
            sb.Append("This is fun!");

            //insert a text within a string at a specified location
            sb.Insert(4, " super");

            //replace fun with awesome
            sb.Replace("fun", "awesome");

            //to retrieve what's in the string so far, do the following:
            var retVal = sb.ToString();

            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }
            return retVal;
        }
    }
}
