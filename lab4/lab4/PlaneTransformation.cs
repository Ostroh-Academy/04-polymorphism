using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    // Клас для перетворення площини
    class PlaneTransformation : Transformation
    {
        // Коефіцієнти перетворення
        private double a11, a12, a13, a21, a22, a23;

        // Реалізація віртуального методу для задання коефіцієнтів перетворення з клавіатури
        public override void SetTransformationCoefficientsFromUserInput()
        {
            Console.WriteLine("Введіть коефіцієнти для трансформації площини:");
            Console.Write("a11: ");
            a11 = double.Parse(Console.ReadLine());
            Console.Write("a12: ");
            a12 = double.Parse(Console.ReadLine());
            Console.Write("a13: ");
            a13 = double.Parse(Console.ReadLine());
            Console.Write("a21: ");
            a21 = double.Parse(Console.ReadLine());
            Console.Write("a22: ");
            a22 = double.Parse(Console.ReadLine());
            Console.Write("a23: ");
            a23 = double.Parse(Console.ReadLine());
        }

        // Реалізація віртуального методу для виведення коефіцієнтів перетворення на екран
        public override void PrintTransformationCoefficients()
        {
            Console.WriteLine($"Коефіцієнти для трансформації площини: a11 = {a11}, a12 = {a12}, a13 = {a13}");
        }

        // Метод для визначення образу заданої точки на площині
        public void TransformPointOnPlane(double x, double y)
        {
            // Обчислення нової координати xNew після застосування трансформації
            double xNew = a11 * x + a12 * y + a13; // Нова координата x

            // Нова координата y залишається незмінною
            double yNew = a21 * x + a22 * y + a23;

            // Виведення образу заданої точки на площині у консоль
            Console.WriteLine($"Образ введеної користувачем точки на площині: ({x}, {y}) = ({xNew}, {yNew})");
        }
    }
}
