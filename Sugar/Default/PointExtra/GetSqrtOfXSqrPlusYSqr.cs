using System;
using System.Drawing;

namespace Sugar
{
    public static partial class PointExtra
    {
        /// <summary>
        /// Sqrt(x^2 + y^2)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int GetSqrtOfXSqrPlusYSqr(int x, int y)
        {
            return (int)Math.Sqrt(x * x + y * y);
        }

    }
}
