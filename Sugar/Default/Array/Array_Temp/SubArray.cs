namespace Sugar
{
    public static partial class Array<Temp>
    {
        /// <summary>
        /// Get 2-dimensional array's part
        /// </summary>
        /// <param name="array">2-dimensional array</param>
        /// <param name="rowStart"></param>
        /// <param name="rowEnd"></param>
        /// <param name="columnStart"></param>
        /// <param name="columnEnd"></param>
        /// <returns></returns>
        public static Temp[,] SubArray(Temp[,] array, int rowStart, int rowEnd, int columnStart, int columnEnd)
        {
            Temp[,] newArray = new Temp[rowEnd - rowStart + 1, columnEnd - columnStart + 1];
            for (int i = rowStart; i <= rowEnd; i++)
                for (int j = columnStart; j <= columnEnd; j++)
                    newArray[i - rowStart, j - columnStart] = array[i, j];
            return newArray;
        }
    }
}