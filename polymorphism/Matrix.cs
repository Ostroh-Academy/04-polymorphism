

using VectorForMatrix;

public class Matrix : VectorFM
{
    public VectorFM[] vectors { get; private set; }
    public Matrix(VectorFM[] vectors)
    {
        this.vectors = vectors;
    }


    public Matrix()
    {
        vectors= new VectorFM[4];
        for (int i = 0; i < vectors.Length; i++)
        {

            vectors[i] = new VectorFM();
        }
    }
    public override void ShowArray()
    {
        Console.WriteLine("Матриця 4х4 :");
        for (int i = 0; i < vectors.Length; i++)
        {
            Console.WriteLine(vectors[i].ToString());
        }
    }
    public override int MaxfromArray()
    {
        int max = vectors[0].MaxfromArray();
        for (int i = 1; i < vectors.Length; i++)
        {
            int currentMax = vectors[i].MaxfromArray();
            if (currentMax > max)
                max = currentMax;
        }
        return max;
    }
    public override void MaxfromArrayShow()
    {
        int max = MaxfromArray();
        Console.WriteLine($"Максимальне значення в матриці  :{max}");
    }


}