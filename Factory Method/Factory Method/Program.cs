using System;

namespace Geometry
{
    class Kula
    {
        protected double b1, b2, b3, R;

        public Kula(double b1 = 0, double b2 = 0, double b3 = 0, double R = 1)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.R = R;
        }

        public virtual void SetCoefficients(double b1, double b2, double b3, double R)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.R = R;
        }

        public virtual void DisplayCoefficients()
        {
            Console.WriteLine($"Центр: ({b1}, {b2}, {b3}), Радіус: {R}");
        }

        public virtual double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
        }
    }

    class Elipsoid : Kula
    {
        private double a1, a2, a3;

        public Elipsoid(double b1 = 0, double b2 = 0, double b3 = 0, double a1 = 1, double a2 = 1, double a3 = 1)
            : base(b1, b2, b3, 1) // R не використовується в еліпсоїді, лише для сумісності
        {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }

        public override void SetCoefficients(double b1, double b2, double b3, double a1, double a2, double a3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }

        public override void DisplayCoefficients()
        {
            Console.WriteLine($"Центр: ({b1}, {b2}, {b3}), Напівосі: a1={a1}, a2={a2}, a3={a3}");
        }

        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * a1 * a2 * a3;
        }
    }

    // Фабричний метод
    interface IGeometryFactory
    {
        Kula CreateGeometry();
    }

    class KulaFactory : IGeometryFactory
    {
        public Kula CreateGeometry()
        {
            return new Kula(1, 2, 3, 4);
        }
    }

    class ElipsoidFactory : IGeometryFactory
    {
        public Kula CreateGeometry()
        {
            return new Elipsoid(1, 2, 3, 4, 5, 6);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть '1' для створення кулі, або будь-яку іншу клавішу для створення еліпсоїда:");
            char userChoose = Console.ReadKey().KeyChar;
            Console.WriteLine();

            IGeometryFactory factory;

            if (userChoose == '1')
            {
                factory = new KulaFactory();
            }
            else
            {
                factory = new ElipsoidFactory();
            }

            Kula shape = factory.CreateGeometry();

            shape.DisplayCoefficients();
            Console.WriteLine($"Об'єм: {shape.Volume()}");
        }
    }
}
