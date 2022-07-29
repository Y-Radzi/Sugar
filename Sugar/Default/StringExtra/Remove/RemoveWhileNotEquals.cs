namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Removes chars from side while not equals target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string RemoveWhileNotEquals(this string str, Side side, char target)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (!str.Contains(target))
                return "";

            switch (side)
            {
                case Side.Left:
                    return str.Substring(str.IndexOf(target));

                case Side.Right:
                    return str.Substring(0, str.LastIndexOf(target) + 1);

                case Side.All:
                    return target.Multiply(str.CountOf(target));

                default:
                    return str;
            }
        }

        /// <summary>
        /// Removes substrings from side while not equals target
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string RemoveWhileNotEquals(this string str, Side side, string target)
        {
            return str.RemoveWhileNotEquals(side, new string[] { target });
        }

        /// <summary>
        /// Removes substrings from side while not equals any of targetArray
        /// </summary>
        /// <param name="str"></param>
        /// <param name="side"></param>
        /// <param name="targetArray"></param>
        /// <returns></returns>
        public static string RemoveWhileNotEquals(this string str, Side side, string[] targetArray)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (!str.ContainsAny(targetArray))
                return "";

            switch (side)
            {
                case Side.Left:
                    return str.Substring(str.IndexOf(targetArray, true));

                case Side.Right:
                    return str.Substring(0, str.LastIndexOf(targetArray, false) + 1);

                case Side.All:

                    string[] splitOfNot = str.Split(targetArray, System.StringSplitOptions.RemoveEmptyEntries);
                    string[] splitResult = str.Split(splitOfNot, System.StringSplitOptions.RemoveEmptyEntries);

                    string result = "";
                    foreach (var temp in splitResult)
                        result += temp;

                    return result;

                default:
                    return str;
            }
        }
    }
}
