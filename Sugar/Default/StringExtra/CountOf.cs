namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Count of searched chars equals target in string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int CountOf(this string str, char target)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int count = 0;

            foreach (char c in str)
                if (c == target)
                    count++;

            return count;
        }
    }
}
