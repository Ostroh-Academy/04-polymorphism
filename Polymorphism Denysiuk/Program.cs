using Polymorphism_Denysiuk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Denysiuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Півплощина
            Halfplane halfplane = new Halfplane();
            halfplane.SetCoefficients(4, 5, 20);
            halfplane.DisplayCoefficients();
            Console.WriteLine("Введiть координати точки для перевiрки (x1 x2):");
            string[] pointInput = Console.ReadLine().Split();
            double x1 = double.Parse(pointInput[0]);
            double x2 = double.Parse(pointInput[1]);
            bool pointInHalfplane = halfplane.IsPointInHalfplane(x1, x2);
            Console.WriteLine($"Чи належить точка данiй пiвплощинi? {pointInHalfplane}");

            // Півпростір
            Halfspace halfspace = new Halfspace();
            halfspace.SetCoefficients(5, 6, 7, 40);
            halfspace.DisplayCoefficients();
            Console.WriteLine("Введiть координати точки для перевiрки (x1 x2 x3):");
            string[] pointInput3D = Console.ReadLine().Split();
            double x3 = double.Parse(pointInput3D[2]);
            bool pointInHalfspace = halfspace.IsPointInHalfplane(x1, x2);
            Console.WriteLine($"Чи належить точка даному пiвпростору? {pointInHalfspace}");
            Console.ReadKey();
        }
    }
}