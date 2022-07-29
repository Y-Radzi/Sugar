namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// "true" if founded case, else - "false"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ToBool(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            str = str.ToLower();
            switch (str)
            {
                case "true":
                case "tru":
                case "tr":
                case "t":
                case "yes":
                case "ye":
                case "y":
                case "yea":
                case "yeah":
                case "1":
                case "+":
                case ">":
                case "да":
                case "д":
                    return true;

                default:
                    return false;
            }
        }
    }
}
