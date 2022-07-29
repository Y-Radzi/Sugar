namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Replaces string if empty
        /// </summary>
        /// <param name="str"></param>
        /// <param name="replacementValue"></param>
        /// <returns></returns>
        public static string ReplaceIfEmpty(this string str, string replacementValue)
        {
            return (string.IsNullOrEmpty(str)) ? replacementValue : str;
        }
    }
}
