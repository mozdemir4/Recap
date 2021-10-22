using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());

            customerManager.Save(new Customer()
            { FirstName = "Muhammet",LastName = "ÖZDEMİR",DateOfBirth = new DateTime(1997,2,20),NationaltyId="546516156",Id=1});
        }
    }

   
}
