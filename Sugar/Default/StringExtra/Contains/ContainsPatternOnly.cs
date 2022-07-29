namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Is string contains only chars of pattern?
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool ContainsPatternOnly(this string str, string pattern)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(pattern))
                return false;

            foreach (char charStr in str)
                foreach (char charPattern in str)
                    if (charPattern != charStr)
                        return false;

            return true;
        }
    }
}