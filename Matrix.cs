namespace MatrixApp
{
    abstract class Matrix
    {
        protected int[] dimensions;

        public Matrix(params int[] dimensions)
        {
            this.dimensions = dimensions;
        }

        public virtual void Set()
        {
            throw new NotImplementedException("Set method must be overridden in derived classes.");
        }

        public virtual void Random()
        {
            throw new NotImplementedException("Random method must be overridden in derived classes.");
        }

        public abstract int Min();
        public static Matrix CreateMatrix(int dimensions)
        {
            switch (dimensions)
            {
                case 2:
                    return new Matrix2D(3, 3);
                case 3:
                    return new Matrix3D(3, 3, 3);
                default:
                    throw new ArgumentException("Матрицi вказаної розмiностi не пiдтримуються");
            }
        }
    }
}