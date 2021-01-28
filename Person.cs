using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public record Person
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public Person(int id, string firstName, string lastName, int age, char gender)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
