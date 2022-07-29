namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Is string contains char?
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool Contains(this string str, char target)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            return (str.IndexOf(target) != -1);
        }
    }
}