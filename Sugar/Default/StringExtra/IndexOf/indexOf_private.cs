namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="targetArray"></param>
        /// <param name="isLastIndex">LastIndexOf or IndexOf</param>
        /// <param name="isTargetLeftSide">Is from start</param>
        /// <returns></returns>
        private static int indexOf(this string str, string[] targetArray, bool isLastIndex, bool isTargetLeftSide)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            int firstIndexLeft = str.Length;
            int firstIndexRight = str.Length;
            int lastIndexLeft = -1;
            int lastIndexRight = -1;

            foreach (var target in targetArray)
                if (!string.IsNullOrEmpty(target))
                {
                    int firstIndexLeftTemp = str.IndexOf(target);

                    if (firstIndexLeftTemp != -1)
                    {
                        int lastIndexLeftTemp = str.LastIndexOf(target);

                        if (firstIndexLeftTemp < firstIndexLeft)
                        {
                            firstIndexLeft = firstIndexLeftTemp;
                            firstIndexRight = firstIndexLeft + target.Length - 1;
                        }

                        if (lastIndexLeftTemp > lastIndexLeft)
                        {
                            lastIndexLeft = lastIndexLeftTemp;
                            lastIndexRight = lastIndexLeft + target.Length - 1;
                        }
                    }
                }

            if (firstIndexLeft == str.Length)
            {
                firstIndexLeft = -1;
                firstIndexRight = -1;
            }

            if (isLastIndex)
                return (isTargetLeftSide) ? lastIndexLeft : lastIndexRight;
            else
                return (isTargetLeftSide) ? firstIndexLeft : firstIndexRight;
        }

    }
}
