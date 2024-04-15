using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paternu__4
{
    public class Ball
    {
        protected double[] coefficients;
        private double radius;


        public Ball(double[] coefficients, double radius)
        {
            this.coefficients = coefficients;
            this.radius = radius;
        }

        public virtual void DisplayShape()
        {
            Console.WriteLine("Форма: Куля");
        }

        // Метод для задання нових коефіцієнтів кулі
        public void SetCoefficients(double[] coefficients)
        {
            this.coefficients = coefficients;
        }

        // Метод для виведення коефіцієнтів на екран консолі
        public void DisplayCoefficients()
        {
            Console.WriteLine("Coefficients:");
            for (int i = 0; i < coefficients.Length; i++)
            {
                Console.WriteLine($"b{i + 1} = {coefficients[i]}");
            }
        }

        // Метод для обчислення об'єму кулі
        public virtual double CalculateVolume()
        {
            // формула V = (4/3) * π * r^3
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            return volume;
        }
    }
}
