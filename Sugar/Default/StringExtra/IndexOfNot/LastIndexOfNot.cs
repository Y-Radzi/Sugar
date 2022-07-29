namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Index of last char in string, which not equals to target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <returns>non-negative number or -1 if not founded</returns>
        public static int LastIndexOfNot(this string str, char target)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            for (int i = str.Length - 1; i >= 0; i--)
                if (str[i] != target)
                    return i;

            return -1;
        }

        /// <summary>
        /// Last founded substring's left or right index, which not equals to target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <param name="isTargetLeftSide"></param>
        /// <returns>non-negative number or -1 if not founded</returns>
        public static int LastIndexOfNot(this string str, string target, bool isTargetLeftSide)
        {
            return str.indexOfNot(target, true, isTargetLeftSide);
        }

        /// <summary>
        /// Last founded element's left or right index, which not equals to any of target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="targetArray"></param>
        /// <param name="isTargetLeftSide"></param>
        /// <returns>non-negative number or -1 if not founded</returns>
        public static int LastIndexOfNot(this string str, string[] targetArray, bool isTargetLeftSide)
        {
            return str.indexOfNot(targetArray, true, isTargetLeftSide);
        }


    }
}