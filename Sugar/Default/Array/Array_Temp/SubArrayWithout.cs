namespace Sugar
{
    public static partial class Array<Temp>
    {
        /// <summary>
        /// Get array without row and column
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rowToExclude"></param>
        /// <param name="columnToExclude"></param>
        /// <returns></returns>
        public static Temp[,] SubArrayWithout(Temp[,] array, int rowToExclude, int columnToExclude)
        {
            Temp[,] result = new Temp[array.GetLength(0) - 1, array.GetLength(1) - 1];
            int i0 = 0;
            int j0 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                if (i != rowToExclude)
                {
                    j0 = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                        if (j != columnToExclude)
                        {
                            result[i0, j0] = array[i, j];
                            j0++;
                        }
                    i0++;
                }
            return result;
        }
    }
}