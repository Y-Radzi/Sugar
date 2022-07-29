namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// Create zero matrix
        /// </summary>
        /// <param name="rowsCount"></param>
        /// <param name="columnsCount"></param>
        /// <returns></returns>
        public static double[,] CreateZero(int rowsCount, int columnsCount) //Создать нулевую матрицу
        {
            double[,] matrix_result = new double[rowsCount, columnsCount];
            for (int i = 0; i < matrix_result.GetLength(0); i++)
                for (int j = 0; j < matrix_result.GetLength(1); j++)
                    matrix_result[i, j] = 0;
            return matrix_result;
        }
    }
}

