using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arrays
{
    public class Linq
    {
        public static IList<string> GetUserNames(string userName)
        {
            var users = new string[] {"Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh"};            
            return users;
        }

        public static List<string> GetSortedUserNames()
        {
            var users = new string[] { "Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh" };
            Array.Sort(users);
            return users.ToList();
        }

        public static string SearchUserName(string userName)
        {
            var users = new string[] {"Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh"};
            string retVal = users.Where(u => u.Contains(userName)).FirstOrDefault();
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

        // Get number in an array in ascending order
        public static IEnumerable<int> GetNumbersWithLINQ()
        {
            var numbers = new int[] { 1, 27, 7, 3, 29, 11, 23, 12, 2, 15 };
            var query = numbers.OrderBy(n => n);
            return query;
        }

        public static List<int> GetSortedNumbers()
        {
            var numbers = new int[] { 1, 27, 7, 3, 29, 11, 23, 12 };
            Array.Sort(numbers);
            return numbers.ToList();
        }

        // Find the number using LINQ query
        public static bool FindNumber(int num)
        {
            var numbers = new int[] { 9, 1, 5, 8, 6, 7, 3, 2, 0, 4, 10, 13, 15, 16, 20 };
            int myVal = numbers.Where(n => n.Equals(num)).FirstOrDefault();
            return myVal.Equals(num);            
        }
    }
}
