namespace Sugar
{
    public static partial class Array<Temp>
    {
        /// <summary>
        /// Get copy of 1-dimensional array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static Temp[] Copy(Temp[] array)
        {
            Temp[] result = new Temp[array.Length];
            array.CopyTo(result, 0);
            return result;
        }

        /// <summary>
        /// Get copy of 2-dimensional array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static Temp[,] Copy(Temp[,] array)
        {
            Temp[,] result = new Temp[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    result[i, j] = array[i, j];
            return result;
        }
    }
}