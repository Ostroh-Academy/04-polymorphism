using System;
using Laba4;

class Program
{
    static void Main(string[] args)
    {
        int userChoose;
        Fraction fraction = null;

        do
        {
            Console.WriteLine("Enter '0' to work with Fraction and '1' to work with ThreeDimensionalFraction or something else to exit:");
            userChoose = Convert.ToInt32(Console.ReadLine());

            if (userChoose == 0)
            {
                Console.WriteLine("Enter the coefficient for Fraction:");
                double coefficient = double.Parse(Console.ReadLine());
                fraction = new Fraction(coefficient);
            }
            else if (userChoose == 1)
            {
                Console.WriteLine("Enter the coefficients for ThreeDimensionalFraction:");
                double coefficient = double.Parse(Console.ReadLine());
                double coefficient2 = double.Parse(Console.ReadLine());
                double coefficient3 = double.Parse(Console.ReadLine());
                fraction = new ThreeDimensionalFraction(coefficient, coefficient2, coefficient3);
            }
            else
            {
                return;
            }

            fraction.PrintCoefficient();
            Console.WriteLine("Enter the value of x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Fraction value at x = " + x + ": " + fraction.CalculateFractionValue(x));

        } while (true);
    }
}
