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

        public static IEnumerable<int> GetNumbers()
        {
            var numbers = new int[] { 9, 1, 5, 8, 6, 7, 3, 2, 0, 4 };

            var query = from number in numbers
                        orderby number ascending
                        select number;
            return query;
        }
    }
}
