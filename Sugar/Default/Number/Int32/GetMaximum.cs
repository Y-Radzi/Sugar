using System.Collections.Generic;

namespace Sugar
{
    public static partial class Number
    {
        /// <summary>
        /// Maximum value of numbers
        /// </summary>
        /// <param name="numberMain"></param>
        /// <param name="numberOther"></param>
        /// <returns></returns>
        public static int GetMaximum(this int numberMain, int numberOther)
        {
            return (numberMain > numberOther) ? numberMain : numberOther;
        }

        /// <summary>
        /// Maximum value of numbers
        /// </summary>
        /// <param name="numberMain"></param>
        /// <param name="numberArray"></param>
        /// <returns></returns>
        public static int GetMaximum(this int numberMain, int[] numbers)
        {
            int result = numberMain;
            foreach(var num in numbers)
                if (result < num)
                    result = num;
            return result;
        }

        /// <summary>
        /// Maximum value of numbers
        /// </summary>
        /// <param name="numberMain"></param>
        /// <param name="numberArray"></param>
        /// <returns></returns>
        public static int GetMaximum(this int numberMain, List<int> numbers)
        {
            int result = numberMain;
            foreach (var num in numbers)
                if (result < num)
                    result = num;
            return result;
        }
    }
}
