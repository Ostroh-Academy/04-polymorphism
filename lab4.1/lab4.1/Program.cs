using System;

namespace GeometryApp
{
    class Line
    {
        // Приватні поля
        private double _a0, _a1, _a2;

        // Публічні властивості для доступу до полів
        public double A0
        {
            get { return _a0; }
            set { _a0 = value; }
        }

        public double A1
        {
            get { return _a1; }
            set { _a1 = value; }
        }

        public double A2
        {
            get { return _a2; }
            set { _a2 = value; }
        }

        // Конструктор
        public Line(double a0, double a1, double a2)
        {
            _a0 = a0;
            _a1 = a1;
            _a2 = a2;
        }

        // Методи для встановлення та виведення коефіцієнтів
        public void SetCoefficients(double a0, double a1, double a2)
        {
            _a0 = a0;
            _a1 = a1;
            _a2 = a2;
        }

        public void PrintCoefficients()
        {
            Console.WriteLine($"Line coefficients: a0 = {_a0}, a1 = {_a1}, a2 = {_a2}");
        }

        // Метод для перевірки належності точки прямій
        public bool IsPointOnLine(double x, double y)
        {
            return Math.Abs(_a1 * x + _a2 * y + _a0) < 1e-10;
        }
    }

    class Hyperplane : Line
    {
        // Додаткові коефіцієнти
        private double _a3, _a4;

        // Конструктор
        public Hyperplane(double a0, double a1, double a2, double a3, double a4)
            : base(a0, a1, a2)
        {
            _a3 = a3;
            _a4 = a4;
        }

        // Методи для встановлення та виведення коефіцієнтів
        public void SetCoefficients(double a0, double a1, double a2, double a3, double a4)
        {
            base.SetCoefficients(a0, a1, a2);
            _a3 = a3;
            _a4 = a4;
        }

        public new void PrintCoefficients()
        {
            base.PrintCoefficients();
            Console.WriteLine($"Hyperplane coefficients: a3 = {_a3}, a4 = {_a4}");
        }

        // Метод для перевірки належності точки гіперплощині
        public bool IsPointOnHyperplane(double x1, double x2, double x3, double x4)
        {
            return Math.Abs(A1 * x1 + A2 * x2 + _a3 * x3 + _a4 * x4 + A0) < 1e-10;
        }
    }

    abstract class GeometryFactory
    {
        public abstract Line CreateLine();
        public abstract Hyperplane CreateHyperplane();
    }

    class LineFactory : GeometryFactory
    {
        public override Line CreateLine()
        {
            return new Line(1, 2, 3);
        }

        public override Hyperplane CreateHyperplane()
        {
            return new Hyperplane(1, 2, 3, 4, 5);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GeometryFactory factory = new LineFactory();

            Line line = factory.CreateLine();
            line.PrintCoefficients();
            Console.WriteLine($"Is point (1, -1) on the line? {line.IsPointOnLine(1, -1)}");

            Hyperplane hyperplane = factory.CreateHyperplane();
            hyperplane.PrintCoefficients();
            Console.WriteLine($"Is point (1, 2, 3, -1) on the hyperplane? {hyperplane.IsPointOnHyperplane(1, 2, 3, -1)}");
        }
    }
}