namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// Get matrix determinant
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double Determinant(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) == 0)
                return 0;
            else if (matrix.GetLength(0) == 1)
                return matrix[0, 0];
            else if (matrix.GetLength(0) == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            else
            {
                double sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    double tempDeterminant = Determinant(SubmatrixWithout(matrix, i, 0)) * matrix[i, 0];
                    if (i % 2 == 0)
                        sum += tempDeterminant;
                    else
                        sum -= tempDeterminant;
                }
                return sum;
            }
        }
    }
}
