namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Removes chars from side while equals target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string RemoveWhileEquals(this string str, Side side, char target)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (!str.Contains(target))
                return str;

            switch (side)
            {
                case Side.Left:
                    return str.Substring(str.IndexOfNot(target));

                case Side.Right:
                    return str.Substring(0, str.LastIndexOfNot(target) + 1);

                case Side.All:
                    return str.RemoveAll(target);

                default:
                    return str;
            }
        }

        /// <summary>
        /// Removes substrings from side while equals target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="targetArray"></param>
        /// <returns></returns>
        public static string RemoveWhileEquals(this string str, Side side, string target)
        {
            return str.RemoveWhileEquals(side, new string[] { target });
        }


        /// <summary>
        /// Removes substrings from side while equals any of targetArray
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="targetArray"></param>
        /// <returns></returns>
        public static string RemoveWhileEquals(this string str, Side side, string[] targetArray)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (!str.ContainsAny(targetArray))
                return str;

            switch (side)
            {
                case Side.Left:
                    return str.Substring(str.IndexOfNot(targetArray, true));

                case Side.Right:
                    return str.Substring(0, str.LastIndexOfNot(targetArray, false) + 1);

                case Side.All:
                    return str.RemoveAll(targetArray);

                default:
                    return str;
            }
        }

    }
}
