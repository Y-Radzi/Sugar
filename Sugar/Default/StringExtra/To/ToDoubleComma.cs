using System;

namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Convert to double with replacing "." to ","
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double ToDoubleComma(this string str)
        {
            return Convert.ToDouble(str.Replace('.', ','));
        }

    }
}
