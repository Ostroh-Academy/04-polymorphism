using System;

namespace VirtualMethodsExample
{
    class Transport
    {
        public virtual void ShowInfo()
        {
            Console.WriteLine("Transport: Generic");
        }
    }

    class Car : Transport
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Transport: Car");
        }
    }

    class Plane : Transport
    {
        public override void ShowInfo()
        {
            Console.WriteLine("Transport: Plane");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transport vehicle;

            Console.WriteLine("Choose a vehicle:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Plane");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                vehicle = new Car();
            }
            else if (choice == 2)
            {
                vehicle = new Plane();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            Console.WriteLine("Information about the chosen vehicle:");
            vehicle.ShowInfo();
        }
    }
}
