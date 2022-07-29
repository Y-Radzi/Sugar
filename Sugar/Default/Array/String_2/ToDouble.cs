using System;

namespace Sugar
{
    public static partial class Array
    {
        /// <summary>
        /// Convert to double array
        /// </summary>
        /// <param name="sArray"></param>
        /// <returns></returns>
        public static double[,] ToDouble(this string[,] sArray)
        {
            double[,] doubleArray = new double[sArray.GetLength(0), sArray.GetLength(1)];
            for (int i = 0; i < sArray.GetLength(0); i++)
                for (int j = 0; j < sArray.GetLength(1); j++)
                    doubleArray[i, j] = Convert.ToDouble(sArray[i, j]);
            return doubleArray;
        }
    }
}
