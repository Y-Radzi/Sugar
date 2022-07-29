using System;

namespace Sugar
{
    public static partial class StringExtra
    {
        /// <summary>
        /// Convert.ToInt32(this)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);
        }

    }
}
