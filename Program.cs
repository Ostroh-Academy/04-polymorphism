using MatrixApp;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("Введiть розмiрнiсть матрицi (2 або 3):\t");
            int dimensions = int.Parse(Console.ReadLine());

            Matrix matrix = Matrix.CreateMatrix(dimensions);
        
        Console.Write($"Оберiть метод задання елементiв матриць:\n1 - задавати значення\n2 - рандомне заповнення\nМетод:\t");
        int elemR = int.Parse(Console.ReadLine());

        if (elemR == 1)
        {
            matrix.Set();
        }
        else
        {
            Console.WriteLine($"Матриця:");
            matrix.Random();
        }

        int minElement = matrix.Min();
        Console.WriteLine($"Мiнiмальний елемент матрицi: {minElement}");

    }
}