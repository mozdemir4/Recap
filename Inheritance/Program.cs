using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[]
            {
              new Student { FirstName="Muhammet",LastName="ÖZDEMİR"},
              new Customer { FirstName="Elif",LastName="ÖZDEMİR"},
              new Person{FirstName ="Semiha",LastName = "ÖZDEMİR"}
            };

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].FirstName+" "+people[i].LastName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string School { get; set; }
    }
}
