using System;

namespace AdvancedInterfaces
{
    class Program
    {
        //interfaces cannot be refreshed
        static void Main(string[] args)
        {


            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());


           
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //customer add codes
            Console.WriteLine("Customer added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        //employee add codes

        public void Add()
        {
            Console.WriteLine("Employee added!");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated!");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
