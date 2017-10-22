using System;

namespace NewtonMethod
{
    public class SqrtNewtonMethod
    {
        public static double FindNthRoot(double number, double n, double eps)
        {
            var x0 = number / n;
            var x1 = (1 / n) * ((n - 1) * x0 + number/ Math.Pow(x0, n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + number / Math.Pow(x0, n - 1));
            }
            if (eps > 0.01)
            {
                return Math.Round(x1, 1);
            }
            else return Math.Round(x1, 5);
        }
    }
}
