namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Get numbers of string from side
        /// </summary>
        /// <param name="targetString"></param>
        /// <param name="side"></param>
        /// <returns></returns>
        public static string GetNumbers(this string targetString, Side side)
        {
            if (side == Side.All)
                return targetString.SubstringExistsInPattern(Numbers, false);
            else if (side == Side.Left)
                return targetString.SubstringExistsInPattern(Numbers, true);
            else if (side == Side.Right)
                return targetString.Inverse().SubstringExistsInPattern(Numbers, true).Inverse();
            else
                return targetString;
        }
    }
}