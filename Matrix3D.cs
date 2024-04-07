namespace MatrixApp
{
    class Matrix3D : Matrix
    {
        private int[,,] matrix;

        public Matrix3D(int rows, int cols, int depth) : base(rows, cols, depth)
        {
            matrix = new int[rows, cols, depth];
        }

        public override void Set()
        {
            Console.WriteLine("Введiть елементи тривимiрної матрицi:");
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    for (int k = 0; k < dimensions[2]; k++)
                    {
                        Console.Write($"matrix[{i},{j},{k}] = ");
                        matrix[i, j, k] = int.Parse(Console.ReadLine());
                    }
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
                    for (int k = 0; k < dimensions[2]; k++)
                    {
                        matrix[i, j, k] = random.Next(-100, 101);
                        Console.Write($"A[{i},{j},{k}] = {matrix[i, j, k]}\n");
                    }
                }
            }
        }

        public override int Min()
        {
            int minElement = matrix[0, 0, 0];
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    for (int k = 0; k < dimensions[2]; k++)
                    {
                        if (matrix[i, j, k] < minElement)
                        {
                            minElement = matrix[i, j, k];
                        }
                    }
                }
            }
            return minElement;
        }
    }
}