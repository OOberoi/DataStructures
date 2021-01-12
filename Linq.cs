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
            var users = new string[] {"Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh"};            
            return users;
        }

        public static string GetUserName()
        {
            var users = new string[] {"Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh"};
            string retVal = users.Where(u => u.Contains("Obi")).FirstOrDefault();
            return retVal;
        }

        public static IEnumerable<int> GetNumbers()
        {
            var numbers = new int[] { 9, 1, 5, 8, 6, 7, 3, 2, 0, 4 };

            var query = from number in numbers
                        orderby number ascending
                        select number;
            return query;
        }

        public static bool FindNumber(int num)
        {
            var numbers = new int[] { 9, 1, 5, 8, 6, 7, 3, 2, 0, 4, 10, 13 };
            int myVal = numbers.Where(n => n.Equals(num)).FirstOrDefault();

            if (myVal.Equals(num))
            {
                return true;
            }
            return false;
        }
    }
}
