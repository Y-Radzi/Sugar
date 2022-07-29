using System;

namespace Sugar
{
    public static partial class Number
    {
        /// <summary>
        /// Convert.ToInt32(this)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int ToInt32(this decimal number)
        {
            return Convert.ToInt32(number);
        }
    }
}
