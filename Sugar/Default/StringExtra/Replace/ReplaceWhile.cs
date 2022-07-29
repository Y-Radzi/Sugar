namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Replaces while exists entries of oldValue in string to newValue
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string ReplaceWhile(this string str, string oldValue, string newValue)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(oldValue))
                return str;

            if (string.IsNullOrEmpty(newValue))
                newValue = "";

            while (str.IndexOf(oldValue) != -1)
                str = str.Replace(oldValue, newValue);

            return str;
        }

        /// <summary>
        /// Replaces while exists entries of oldValue in string to newValue
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string ReplaceWhile(this string str, string oldValue, char newValue)
        {
            return str.ReplaceWhile(oldValue, newValue.ToString());
        }

        /// <summary>
        /// Replaces while exists entries of oldValue in string to newValue
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string ReplaceWhile(this string str, char oldValue, string newValue)
        {
            return str.ReplaceWhile(oldValue.ToString(), newValue);
        }

        /// <summary>
        /// Replaces while exists entries of oldValue in string to newValue
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string ReplaceWhile(this string str, char oldValue, char newValue)
        {
            return str.ReplaceWhile(oldValue.ToString(), newValue.ToString());
        }

    }
}
