namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// String.IsNullOrEmpty(...), but comfortable
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
