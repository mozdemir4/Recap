using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //polimorfizm

            ICustomerDal[] customerDals = new ICustomerDal[] { new OracleServerCustomerDal(), new SqlServerCustomerDal()};

            for (int i = 0; i < customerDals.Length; i++)
            {
                customerDals[i].Add();
            }

        }

   
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
