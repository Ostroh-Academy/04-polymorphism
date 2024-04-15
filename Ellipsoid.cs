using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paternu__4
{
    public class Ellipsoid : Ball
    {
        public Ellipsoid(double[] coefficients, double radius) : base(coefficients, radius)
        {
            // Конструктор класу Ellipsoid викликає конструктор базового класу Ball
        }

        public override void DisplayShape()
        {
            Console.WriteLine("Форма: Еліпсоїд");
        }

        // Перевантажуємо метод задання відповідних коефіцієнтів
        public new void SetCoefficients(double[] coefficients)
        {
            // Ми використовуємо ключове слово "new", щоб вказати, що перевизначаємо метод базового класу
            base.SetCoefficients(coefficients); // Викликаємо метод базового класу для встановлення коефіцієнтів
        }

        // Перевантажуємо метод виведення відповідних коефіцієнтів на екран
        public new void DisplayCoefficients()
        {
           
            base.DisplayCoefficients(); 
        }

        // Метод для обчислення об'єму еліпсоїда
        public override double CalculateVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * coefficients[0] * coefficients[1] * coefficients[2];
            return volume;
        }
    }
}
