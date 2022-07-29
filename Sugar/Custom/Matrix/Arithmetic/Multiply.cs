namespace Sugar
{
    public static partial class Matrix
    {
        /// <summary>
        /// matrix1 * matrix2
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                double[,] matrixResult = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
                for (int i_ans = 0; i_ans < matrix1.GetLength(0); i_ans++)
                    for (int j_ans = 0; j_ans < matrix2.GetLength(1); j_ans++)
                        for (int i = 0; i < matrix1.GetLength(1); i++)
                            matrixResult[i_ans, j_ans] += matrix1[i_ans, i] * matrix2[i, j_ans];
                return matrixResult;
            }
            else if (matrix2.GetLength(0) == 1 && matrix2.GetLength(1) == 1)
                return Multiply(matrix1, matrix2[0, 0]);
            else
                throw new System.Exception(
                    "Error multiply; Matrix1: " + Array<double>.Display(matrix1)
                    + "; Matrix2: " + Array<double>.Display(matrix2));
        }

        /// <summary>
        /// matrix * number
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double[,] Multiply(double[,] matrix, double number)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] *= number;
            return matrix;
        }

    }
}
