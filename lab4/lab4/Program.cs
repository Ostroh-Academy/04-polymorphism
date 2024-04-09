using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Перетворення площини
            PlaneTransformation planeTransform = new PlaneTransformation();
            planeTransform.SetTransformationCoefficientsFromUserInput();
            planeTransform.PrintTransformationCoefficients();

            // Перетворення точки
            PointTransformation pointTransform = new PointTransformation();
            pointTransform.SetTransformationCoefficientsFromUserInput();
            pointTransform.PrintTransformationCoefficients();

            Console.WriteLine("Введіть початкові координати (x, y, z) для трансформації:");
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z: ");
            double z = double.Parse(Console.ReadLine());

            pointTransform.TransformPoint(x, y, z);

            // Виклик методу для визначення образу точки на площині
            planeTransform.TransformPointOnPlane(x, y);

            Console.WriteLine("Натисніть будь-яку кнопку для виходу");
            Console.ReadKey();
        }
    }
}