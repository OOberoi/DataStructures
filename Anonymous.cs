using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Anonymous
    {
        private static void GetStudentDetails()
        {
            IList<Pupil> pupList = new List<Pupil>() { 
                new Pupil() { ID = 1, FirstName = "Obi", LastName = "Oberoi"},
                new Pupil() { ID = 2, FirstName = "Scott", LastName = "Hanselman" },
                new Pupil() { ID = 3, FirstName = "Scott", LastName = "Hunter" },
                new Pupil() { ID = 4, FirstName = "Dan", LastName = "Roth" },
                new Pupil() { ID = 5, FirstName = "Jessie", LastName = "Liberty" },
            };

            var pups = pupList.ToList();
            foreach (var item in pups)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
            }
            Console.ReadLine();
        }
    }

    public class Pupil
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    public class Address
    {
        public int AddressId { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }

    }
}
