namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// Get inverted matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public static double[,] Inverse(double[,] matrix)
        {
            if (matrix.GetLength(0) == 1 && matrix.GetLength(1) == 1)
                return new double[,] { { (matrix[0, 0] == 0) ? 0 : 1 / matrix[0, 0] } };
            else if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                double[,] matrixTemp = new double[matrix.GetLength(0), matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                    for (int i = 0; i < matrix.GetLength(0); i++)
                        matrixTemp[i, j] = Determinant(SubmatrixWithout(matrix, j, i)) * System.Math.Pow(-1, i + j);
                return Multiply(matrixTemp, 1 / Determinant(matrix));
            }
            else
                throw new System.Exception($"Can't invert matrix, rows {matrix.GetLength(0)} != columns {matrix.GetLength(1)}; "
                    + Array<double>.Display(matrix));
        }
    }
}
