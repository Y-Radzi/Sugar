namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Get substring from side contains chars not equals target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string SubstringWhileNotEquals(this string str, Side side, char target)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            int index = str.IndexOf(target);

            if (index == -1)
                return str;

            switch (side)
            {
                case Side.Left:
                    return str.Substring(0, index);

                case Side.Right:
                    int startIndex = str.LastIndexOf(target) + 1;
                    return (startIndex >= str.Length) ? "" : str.Substring(startIndex);

                case Side.All:
                    return str.RemoveAll(target);

                default:
                    return str;
            }
        }

    }
}
