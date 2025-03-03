namespace FilterArrayLab {
    public class Client {
        public delegate double FractionFormula(int x);

        public static void Main() {
            int precision = int.Parse(Console.ReadLine());

            FractionFormula sumpow = n => 1.0 / Math.Pow(2,n);
            FractionFormula sumfact = n => 1.0 / factorial(n);
            FractionFormula sumngv = n => Math.Pow(-1, n+1) / Math.Pow(2,n);

            Console.WriteLine(SumWithPrecisionOf(precision,sumpow));
            Console.WriteLine(SumWithPrecisionOf(precision,sumfact));
            Console.WriteLine(SumWithPrecisionOf(precision,sumngv));
        }

        static double SumWithPrecisionOf(int p, FractionFormula frac) {
            double sum = 0.0;
            for (int i = 0; i<=p; ++i) {
                sum += frac(i);
            }
            return sum;
        }

        static double factorial(int n) {
            double res = 1.0;
            for (int i = 1; i<=n; ++i)
                res *= i;
            return res;
        }
    }
}