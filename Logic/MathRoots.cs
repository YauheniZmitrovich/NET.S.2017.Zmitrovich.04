using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

    /// <summary>
    /// Helps to compute math roots by various methods.
    /// </summary>
    public class MathRoots
    {

        #region Newton's roots

        /// <summary>
        /// Computes root of n degree from <paramref name="number"/> by Newton's method.
        /// </summary>
        /// <param name="number"> Number to root extracting. </param>
        /// <param name="n"> Degree of root. </param>
        /// <param name="e"> Accurancy of computing. </param>
        /// <returns> Root of n degree from number. </returns>
        /// <exception cref="ArgumentException">
        /// Have a place:
        /// 1. <paramref name="n"/> is less than 1.
        /// 2. <paramref name="e"/> isn't belong to the interval [ 0, 1 ].
        /// 3. <paramref name="n"/> is even and <paramref name="value"/> is less than zero.
        /// </exception>
        public static double NewtonRoot(double number, double n, double e)
        {
            bool flag1 = n < 1 || e <= 0 || e >= 1;
            bool flag2 = (number < 0 && (n % 2 == 0));
            if (flag1 || flag2)
                throw new System.ArgumentException();

            double x0 = number / n;
            double x = ((n - 1) * x0 + number / Math.Pow(x0, n - 1)) / n;

            while (Math.Abs(x - x0) > e)
            {
                x0 = x;
                x = ((n - 1) * x0 + number / Math.Pow(x0, n - 1)) / n;
            }

            return x;
        }

        #endregion

    }
}

