namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Get inverted string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Inverse(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
                result += str[i];
            return result;
        }
    }
}