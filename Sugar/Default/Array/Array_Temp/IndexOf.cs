namespace Sugar
{
    public static partial class Array<Temp>
    {
        /// <summary>
        /// Index of 2-dimensional array's element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>{ int index at GetLength(0), int index at GetLength(1) } or { -1, -1 } if not founded</returns>
        public static int[] IndexOf(Temp[,] array, Temp target)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (target.Equals(array[i, j]))
                        return new int[] { i, j };
            return new int[] { -1, -1 };
        }

        /// <summary>
        /// Index of 1-dimensional array's element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>int index or -1 if not founded</returns>
        public static int IndexOf(Temp[] array, Temp target)
        {
            for (int i = 0; i < array.Length; i++)
                if (target.Equals(array[i]))
                    return i;
            return -1;
        }
    }
}
