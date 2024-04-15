using Paternu__4;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Який об'єкт ви хочете створити?");
            Console.WriteLine("1. Куля");
            Console.WriteLine("2. Еліпсоїд");
            int choice = Convert.ToInt32(Console.ReadLine());

            double[] coefficients = { 3.0, 4.0, 5.0 };
            double radius = 5.0;

            Ball shape;

            if (choice == 1)
            {
                Console.WriteLine("Введіть радіус кулі:");
                radius = Convert.ToDouble(Console.ReadLine());
                coefficients = new double[] { radius };
                shape = new Ball(coefficients, radius);
            }
            else
            {
                Console.WriteLine("Введіть довжини піввісей еліпсоїда (a, b, c):");
                coefficients = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Введіть значення для піввісі {(char)('a' + i)}: ");
                    coefficients[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Введіть радіус еліпсоїда:");
                radius = Convert.ToDouble(Console.ReadLine());
                shape = new Ellipsoid(coefficients, radius);
            }

            shape.DisplayShape();
            Console.WriteLine($"Об'єм: {shape.CalculateVolume()}");

            Console.ReadLine();
        }
    

    }
}
