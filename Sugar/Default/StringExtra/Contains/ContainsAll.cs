namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Is string contains all strings of array?
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchArray"></param>
        /// <returns></returns>
        public static bool ContainsAll(this string str, string[] searchArray)
        {
            if (string.IsNullOrEmpty(str) || searchArray.Length == 0)
                return false;

            foreach (var search in searchArray)
                if (str.IndexOf(search) == -1)
                    return false;

            return true;
        }

        /// <summary>
        /// Is string contains all chars of string?
        /// </summary>
        /// <param name="str"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static bool ContainsAll(this string str, string chars)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(chars))
                return false;

            foreach (var patternChar in chars)
                if (str.IndexOf(patternChar) == -1)
                    return false;

            return true;
        }
    }
}