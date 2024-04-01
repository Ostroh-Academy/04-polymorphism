using System;
using System.Text;
using System.Threading;
using VectorForMatrix;

namespace MatrixFactoryPattern
{
    public class MatrixFactory
    {
        public static VectorFM CreateVectorFM(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new VectorFM();
                case 2:
                    return new Matrix();
                default:
                    Console.WriteLine(" Створено вектор за замовчуванням.");
                    return new VectorFM(4, 2, 4, 7);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Виберіть з чим ви хочете працювати :");
            Console.WriteLine("1. Vector");
            Console.WriteLine("2. Matrix");

            int choice = int.Parse(Console.ReadLine());
            VectorFM vector = MatrixFactory.CreateVectorFM(choice);
            vector.ShowArray();
            vector.MaxfromArrayShow();
            Thread.Sleep(10000);
        }
    }
}
