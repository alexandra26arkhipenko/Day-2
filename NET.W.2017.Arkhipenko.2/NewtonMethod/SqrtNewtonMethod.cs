using System;

namespace NewtonMethod
{
    /// <summary>
    /// Newthon method
    /// </summary>
    public class SqrtNewtonMethod
    {
        #region public
        /// <summary>
        /// the method FindNthRoot calculates the root of the nth power (n∈N) from the number (a∈R) by the Newton method with a given accuracy
        /// </summary>
        /// <param name="number"></param>
        /// <param name="n"></param>
        /// <param name="eps"></param>
        /// <returns>double x1 </returns>

        public static double FindNthRoot(double number, double n, double eps)
        {
            if (n <= 0)
                throw new ArgumentException($"{nameof(n)} must be greater than 0", nameof(n));

            if ((number <= 0) && (n % 2 == 0))
                throw new ArgumentException($"{nameof(number)} must be greater than or equal to 0", nameof(number));

            if (eps <= 0)
                throw new ArgumentException($"{nameof(eps)} must be greater than 0", nameof(eps));

            var x0 = number / n;
            var x1 = (1 / n) * ((n - 1) * x0 + number/ Math.Pow(x0, n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + number / Math.Pow(x0, n - 1));
            }
            return x1;
        }
        #endregion
    }
}
