namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Is string contains any chars of array?
        /// </summary>
        /// <param name="str"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static bool ContainsAny(this string str, char[] chars)
        {
            if (string.IsNullOrEmpty(str) || chars.Length == 0)
                return false;

            foreach (var patternChar in chars)
                if (str.IndexOf(patternChar) != -1)
                    return true;

            return false;
        }

        /// <summary>
        /// Is string contains any chars of string?
        /// </summary>
        /// <param name="str"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static bool ContainsAny(this string str, string chars)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(chars))
                return false;

            foreach (var patternChar in chars)
                if (str.IndexOf(patternChar) != -1)
                    return true;

            return false;
        }

        /// <summary>
        /// Is string contains any string of array?
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchArray"></param>
        /// <returns></returns>
        public static bool ContainsAny(this string str, string[] searchArray)
        {
            if (string.IsNullOrEmpty(str) || searchArray.Length == 0)
                return false;

            foreach (var search in searchArray)
                if (str.IndexOf(search) != -1)
                        return true;

            return false;
        }

    }
}