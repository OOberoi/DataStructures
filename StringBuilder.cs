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
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello Obi!");
            sb.Append("This is fun!");
            return sb.ToString();
        }
    }
}
