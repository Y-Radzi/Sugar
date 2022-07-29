namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// matrix1 + matrix2
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    matrix1[i, j] += matrix2[i, j];
            return matrix1;
        }
    }
}
