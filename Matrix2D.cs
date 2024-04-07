namespace MatrixApp
{
    class Matrix2D : Matrix
    {
        private int[,] matrix;

        public Matrix2D(int rows, int cols) : base(rows, cols)
        {
            matrix = new int[rows, cols];
        }

        public override void Set()
        {
            Console.WriteLine("Введiть елементи двовимiрної матрицi:");
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void Random()
        {
            Random random = new Random();
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i, j] = random.Next(-100, 101);
                    Console.Write($"A[{i},{j}] = {matrix[i, j]}\n");
                }
            }
        }

        public override int Min()
        {
            int minElement = matrix[0, 0];
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }
            return minElement;
        }
    }
}