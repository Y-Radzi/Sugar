namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Replaces entries if exists of oldValueArray in string to newValue
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValueArray"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string Replace(this string str, string[] oldValueArray, string newValue)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (string.IsNullOrEmpty(newValue))
                newValue = "";

            foreach (string searchString in oldValueArray)
                if (!string.IsNullOrEmpty(searchString))
                    str = str.Replace(searchString, newValue);

            return str;
        }

        /// <summary>
        /// Replaces entries if exists of oldValue in string to newValue as string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string Replace(this string str, string oldValue, char newValue)
        {
            return str.Replace(oldValue, newValue.ToString());
        }

        /// <summary>
        /// Replaces entries if exists of oldValue as string in string to newValue
        /// </summary>
        /// <param name="str"></param>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public static string Replace(this string str, char oldValue, string newValue)
        {
            return str.Replace(oldValue.ToString(), newValue);
        }

    }
}
