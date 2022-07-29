namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Repeat char "count" times: 'a'.Multiply(4) = "aaaa"
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string Multiply(this char pattern, int count)
        {
            if (count <= 0)
                return "";

            string result = "";

            for (int i = 0; i < count; i++)
                result += pattern.ToString();

            return result;
        }

        /// <summary>
        /// Repeat string "count" times: "abc".Multiply(4) = "abcabcabcabc"
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string Multiply(this string pattern, int count)
        {
            if (string.IsNullOrEmpty(pattern) || count <= 0)
                return "";

            string result = "";

            for (int i = 0; i < count; i++)
                result += pattern;

            return result;
        }
    }
}
