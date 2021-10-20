using System;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Muhammet";
            customer1.LastName = "ÖZDEMİR";
            customer1.City = "Ankara";

            Customer customer2 = new Customer
            { 
                Id = 1,
                FirstName ="Semra",
                LastName = "YÜCESOY",
                City = "Ordu"
            };

            Console.WriteLine(customer1.FirstName);

        }
    }

}
