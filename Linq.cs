﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arrays
{
    public class Linq
    {
        public static IList<string> GetUserNames(string userName)
        {
            var users = new string[] { "Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh" };
            return users;
        }

        public static List<Student> FindStudent(string name)
        {
            try
            {
                Student[] studArray = {
                new Student() { ID = 1, StudentName = "Rowan Atkins", Age = 20, Gender = 'M' },
                new Student() {ID = 2, StudentName = "Arya Oberoi", Age = 14, Gender = 'M' }
                };

                var retVal = studArray.Where(s => s.StudentName.Contains(name)).FirstOrDefault();
                return studArray.ToList();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        public static List<string> GetSortedUserNames()
        {
            var users = new string[] { "Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh" };
            Array.Sort(users);
            return users.ToList();
        }

        public static string SearchUserName(string userName)
        {
            var users = new string[] { "Obi", "Sunita", "Sia", "Arya", "Krishan", "Kamlesh" };
            string retVal = users.Where(u => u.Contains(userName)).FirstOrDefault();
            return retVal;
        }

        public static string SearchByPartialName(string empName)
        {
            var names = new string[] { "Obi", "Michael", "Mark", "Rachel", "Pam", "Suzanne", "Pranay" };
            var retVal = from name in names
                         where name.Contains(empName)
                         select name;
            return retVal.ToString();
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

    public class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
    }
}
