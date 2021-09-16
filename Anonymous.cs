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


            };
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
