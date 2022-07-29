namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Get substring from side contains chars equals target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string SubstringWhileEquals(this string str, Side side, char target)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            int index = str.IndexOfNot(target);

            if (index == -1)
                return "";

            switch (side)
            {
                case Side.Left:
                    return str.Substring(0, index);

                case Side.Right:
                    int startIndex = str.LastIndexOfNot(target) + 1;
                    return (startIndex >= str.Length) ? "" : str.Substring(startIndex);

                case Side.All:
                    return target.Multiply(str.CountOf(target));

                default:
                    return str;
            }
        }

    }
}
