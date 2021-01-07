using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arrays
{
    public class Linq
    {
        public static IList<string> GetUserNames()
        {
            var users = new string[] { "Obi", "Sunita", "Sia", "Arya" };
            var query = users.Where(u => users.Contains("Obi")).ToList();
            return query;
        }
    }
}
