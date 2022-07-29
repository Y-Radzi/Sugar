namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// Get matrix without row and column
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="rowToExclude"></param>
        /// <param name="columnToExclude"></param>
        /// <returns></returns>
        public static double[,] SubmatrixWithout(double[,] matrix, int rowToExclude, int columnToExclude)
        {
            double[,] result = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            int i0 = 0;
            int j0 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                if (i != rowToExclude)
                {
                    j0 = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (j != columnToExclude)
                        {
                            result[i0, j0] = matrix[i, j];
                            j0++;
                        }
                    i0++;
                }
            return result;
        }
    }
}
