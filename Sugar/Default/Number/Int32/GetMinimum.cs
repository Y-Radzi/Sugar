using System.Collections.Generic;

namespace Sugar
{
    public static partial class Number
    {
        /// <summary>
        /// Minimum value of numbers
        /// </summary>
        /// <param name="numberMain"></param>
        /// <param name="numberOther"></param>
        /// <returns></returns>
        public static int GetMinimum(this int numberMain, int numberOther)
        {
            return (numberMain < numberOther) ? numberMain : numberOther;
        }

        /// <summary>
        /// Minimum value of numbers
        /// </summary>
        /// <param name="numberMain"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GetMinimum(this int numberMain, int[] numbers)
        {
            int result = numberMain;
            foreach(var num in numbers)
                if (result > num)
                    result = num;
            return result;
        }

        /// <summary>
        /// Minimum value of numbers
        /// </summary>
        /// <param name="numberMain"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GetMinimum(this int numberMain, List<int> numbers)
        {
            int result = numberMain;
            foreach (var num in numbers)
                if (result > num)
                    result = num;
            return result;
        }
    }
}
