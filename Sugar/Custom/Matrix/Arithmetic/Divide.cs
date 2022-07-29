namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// matrix1 / matrix2
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static double[,] Divide(double[,] matrix1, double[,] matrix2)
        {
            return Multiply(matrix1, Inverse(matrix2));
        }

        /// <summary>
        /// matrix1 / number
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double[,] Divide(double[,] matrix1, double number)
        {
            return Multiply(matrix1, 1 / number);
        }

    }
}
