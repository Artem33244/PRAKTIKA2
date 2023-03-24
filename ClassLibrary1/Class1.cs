namespace ClassLibrary1
{

    public class QuadraticEquationSolver
    {
        private double a;
        private double b;
        private double c;
        private double x1;
        private double x2;

        public QuadraticEquationSolver(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private double CalculateDiscriminant()
        {
            return b * b - 4 * a * c;
        }

        private void CalculateRoots()
        {
            double discriminant = CalculateDiscriminant();
            if (discriminant < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("One real root: {0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Two real roots: {0}, {1}", x1, x2);
            }
        }

        public void Solve()
        {
            CalculateRoots();
        }

        public double GetA()
        {
            return a;
        }

        public double GetB()
        {
            return b;
        }

        public double GetC()
        {
            return c;
        }

        public double GetX1()
        {
            return x1;
        }

        public double GetX2()
        {
            return x2;
        }
    }

}