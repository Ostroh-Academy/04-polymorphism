using System;

class TwoDimensionalMatrix
{
    protected int[,] matrix;

    public TwoDimensionalMatrix()
    {
        matrix = new int[3, 3];
    }

    public virtual void SetMatrixByUserInput()
    {
        Console.WriteLine("Enter elements of the 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    public virtual void SetMatrixByRandom()
    {
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = random.Next(1, 100); 
            }
        }
    }

    public int FindMinimum()
    {
        int min = matrix[0, 0];
        foreach (int element in matrix)
        {
            if (element < min)
                min = element;
        }
        return min;
    }
}

class ThreeDimensionalMatrix : TwoDimensionalMatrix
{
    public ThreeDimensionalMatrix() : base() { }

    public override void SetMatrixByUserInput()
    {
        Console.WriteLine("Enter elements of the 3x3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"Enter element [{i},{j},{k}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }

    public override void SetMatrixByRandom()
    {
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    matrix[i, j] = random.Next(1, 100); 
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TwoDimensionalMatrix twoDMatrix = new TwoDimensionalMatrix();
        ThreeDimensionalMatrix threeDMatrix = new ThreeDimensionalMatrix();

        twoDMatrix.SetMatrixByUserInput();
        Console.WriteLine($"Minimum element in the 2D matrix: {twoDMatrix.FindMinimum()}");

        twoDMatrix.SetMatrixByRandom();
        Console.WriteLine($"Minimum element in the randomly generated 2D matrix: {twoDMatrix.FindMinimum()}");

        threeDMatrix.SetMatrixByUserInput();
        Console.WriteLine($"Minimum element in the 3D matrix: {threeDMatrix.FindMinimum()}");

        threeDMatrix.SetMatrixByRandom();
        Console.WriteLine($"Minimum element in the randomly generated 3D matrix: {threeDMatrix.FindMinimum()}");
    }
}
