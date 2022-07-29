namespace Sugar
{
    public static partial class StringExtra
    {
        
        /// <summary>
        /// Remove last char in string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveLastChar(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return str.Substring(0, str.Length - 1);
        }

        /// <summary>
        /// Remove last char in string if it equals pattern
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string RemoveLastChar(this string str, char pattern)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return (str[str.Length - 1] == pattern) ? str.Substring(0, str.Length - 1) : str;
        }

    }
}
