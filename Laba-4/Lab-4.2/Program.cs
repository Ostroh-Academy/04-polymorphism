using System;

namespace FactoryMethodPattern
{
    interface ITransport
    {
        void ShowInfo();
    }

    class Car : ITransport
    {
        public void ShowInfo()
        {
            Console.WriteLine("Transport: Car");
        }
    }

    class Plane : ITransport
    {
        public void ShowInfo()
        {
            Console.WriteLine("Transport: Plane");
        }
    }

    interface ITransportFactory
    {
        ITransport CreateTransport();
    }

    class CarFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new Car();
        }
    }

    class PlaneFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new Plane();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a vehicle:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Plane");
            int choice = Convert.ToInt32(Console.ReadLine());

            ITransportFactory transportFactory;
            switch (choice)
            {
                case 1:
                    transportFactory = new CarFactory();
                    break;
                case 2:
                    transportFactory = new PlaneFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            ITransport vehicle = transportFactory.CreateTransport();

            Console.WriteLine("Information about the chosen vehicle:");
            vehicle.ShowInfo();
        }
    }
}
