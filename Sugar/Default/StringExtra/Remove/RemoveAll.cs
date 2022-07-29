namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Removes all entries of target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string RemoveAll(this string str, char target)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return str.Replace(target.ToString(), "");
        }

        /// <summary>
        /// Removes all entries of target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string RemoveAll(this string str, string target)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (string.IsNullOrEmpty(target))
                return str;

            return str.Replace(target, "");
        }

        /// <summary>
        /// Removes all entries of targetArray
        /// </summary>
        /// <param name="str"></param>
        /// <param name="targetArray"></param>
        /// <returns></returns>
        public static string RemoveAll(this string str, string[] targetArray)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return str.Replace(targetArray, "");
        }

    }
}
