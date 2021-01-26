using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public Person(string firstName, string lastName, int age, char gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
