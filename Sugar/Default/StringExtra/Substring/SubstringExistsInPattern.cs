namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Get substring contains chars of pattern only
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pattern"></param>
        /// <param name="isBreakWhenNoPattern"></param>
        /// <returns></returns>
        public static string SubstringExistsInPattern(this string str, string pattern, bool isBreakWhenNoPattern)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(pattern))
                return "";

            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (pattern.IndexOf(str[i]) != -1) //if char in pattern
                    result += str[i];
                else if (isBreakWhenNoPattern)
                    break;
            }
            return result;
        }
    }
}
