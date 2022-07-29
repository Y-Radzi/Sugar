namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// matrix1 - matrix2
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static double[,] Minus(double[,] matrix1, double[,] matrix2)
        {
            return Subtract(matrix1, matrix2);
        }

    }
}
