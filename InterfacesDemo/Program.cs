using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] { new Manager(), new Worker(), new Robot() };

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Work();
            }

            IEat[] eats = new IEat[] { new Manager(), new Worker() };

            for (int i = 0; i < eats.Length; i++)
            {
                eats[i].Eat();
            }

        }
    }

    interface IWorker
    {
        void Work();
   
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("You can go to dinner");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Do work manager");
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("You can go to dinner");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Do work worker");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Do work robot");
        }
    }
}
