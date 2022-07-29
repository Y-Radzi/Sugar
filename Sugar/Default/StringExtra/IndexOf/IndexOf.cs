namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// First founded array element's left or right index
        /// </summary>
        /// <param name="str"></param>
        /// <param name="targetArray"></param>
        /// <param name="isTargetLeftSide"></param>
        /// <returns>non-negative number or -1 if not founded</returns>
        public static int IndexOf(this string str, string[] targetArray, bool isTargetLeftSide)
        {
            return str.indexOf(targetArray, false, isTargetLeftSide);
        }
    }
}
