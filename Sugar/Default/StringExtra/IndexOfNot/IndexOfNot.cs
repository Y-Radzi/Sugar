namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Index of first char in string, which not equals to target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <returns>non-negative number or -1 if not founded</returns>
        public static int IndexOfNot(this string str, char target)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            for (int i = 0; i < str.Length; i++)
                if (str[i] != target)
                    return i;

            return -1;
        }

        /// <summary>
        /// First founded substring's left or right index, which not equals to target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <param name="isTargetLeftSide"></param>
        /// <returns>non-negative number or -1 if not founded</returns>
        public static int IndexOfNot(this string str, string target, bool isTargetLeftSide)
        {
            return str.indexOfNot(target, false, isTargetLeftSide);
        }

        /// <summary>
        /// First founded element's left or right index, which not equals to any of target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="targetArray"></param>
        /// <param name="isTargetLeftSide"></param>
        /// <returns>non-negative number or -1 if not founded</returns>
        public static int IndexOfNot(this string str, string[] targetArray, bool isTargetLeftSide)
        {
            return str.indexOfNot(targetArray, false, isTargetLeftSide);
        }




    }
}