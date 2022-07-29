namespace Sugar
{
    public static partial class Array<Temp>
    {
        /// <summary>
        /// View 2-dimensional array's data as string
        /// </summary>
        /// <param name="array">2-dimensional array</param>
        /// <param name="dividerRow">row divider</param>
        /// <param name="dividerColumn">column divider</param>
        /// <param name="isShowIndexes">column divider</param>
        /// <returns></returns>
        public static string Display(Temp[,] array, string dividerRow, string dividerColumn, bool isShowIndexes)
        {
            string result = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                result += ((i == 0) ? "" : dividerRow);

                for (int j = 0; j < array.GetLength(1); j++)
                    result += ((isShowIndexes) ? $"[{i}{StringExtra.SplitterHeaderOfLineDefault}{j}]" : "")
                        + ((j == 0) ? "" : dividerColumn)
                        + array[i, j].ToString();
            }
            return result;
        }

        /// <summary>
        /// View 2-dimensional array's data as string with default dividers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string Display(Temp[,] array)
        {
            return Display(array, StringExtra.SplitterRowDefault, StringExtra.SplitterColumnDefault, false);
        }
    }
}