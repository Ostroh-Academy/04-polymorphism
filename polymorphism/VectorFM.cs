namespace VectorForMatrix
{
    public class VectorFM
    {
        public int[] vector { get; private set; }
        public VectorFM(int[] array)
        {
            vector = new int[4];
            if (array.Length != 4)
            {
                Console.WriteLine("Вектор може містити тільки 4 елементи");
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                vector[i] = array[i];
            }
        }
        public VectorFM(int a, int b, int c, int d)
        {
            vector = new[] { a, b, c, d };

        }
        public VectorFM()
        {
            vector = new int[4];
            Random random = new Random();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next()%10; 
            }

        }
        public virtual void ShowArray()
        {
            Console.WriteLine($"Вектор : {vector[0]} {vector[1]} {vector[2]} {vector[3]}");
        }
        public override string ToString()
        {
            return $"{vector[0]} {vector[1]} {vector[2]} {vector[3]}";
        }

        public virtual int MaxfromArray()
        {
            int max = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if (max < vector[i])
                    max = vector[i];
            }
            return max;
        }
        public virtual void MaxfromArrayShow()
        {
            int max = MaxfromArray();
            Console.WriteLine($"Максимальне значення в векторі :{max}");
        }
    }
}