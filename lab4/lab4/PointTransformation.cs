using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    // Клас для перетворення точки
    class PointTransformation : Transformation
    {
        // Коефіцієнти перетворення
        private double a11, a12, a13, a21, a22, a23, a31, a32, a33;

        // Реалізація віртуального методу для задання коефіцієнтів перетворення з клавіатури
        public override void SetTransformationCoefficientsFromUserInput()
        {
            Console.WriteLine("Введіть коефіцієнти для трасформації точки:");
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
            Console.Write("a31: ");
            a31 = double.Parse(Console.ReadLine());
            Console.Write("a32: ");
            a32 = double.Parse(Console.ReadLine());
            Console.Write("a33: ");
            a33 = double.Parse(Console.ReadLine());
        }

        // Реалізація віртуального методу для виведення коефіцієнтів перетворення на екран
        public override void PrintTransformationCoefficients()
        {
            Console.WriteLine($"Коефіцієнти трансформації точки:");
            Console.WriteLine($"a11 = {a11}, a12 = {a12}, a13 = {a13}");
            Console.WriteLine($"a21 = {a21}, a22 = {a22}, a23 = {a23}");
            Console.WriteLine($"a31 = {a31}, a32 = {a32}, a33 = {a33}");
        }

        // Метод для визначення образу заданої точки (x, y, z)
        public void TransformPoint(double x, double y, double z)
        {
            double xNew = a11 * x + a12 * y + a13 * z;
            double yNew = a21 * x + a22 * y + a23 * z;
            double zNew = a31 * x + a32 * y + a33 * z;
            Console.WriteLine($"Образ введеної користувачем точки: ({x}, {y}, {z}) = ({xNew}, {yNew}, {zNew})");
        }
    }
}