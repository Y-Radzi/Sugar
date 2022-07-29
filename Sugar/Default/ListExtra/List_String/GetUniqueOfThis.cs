using System.Collections.Generic;

namespace Sugar
{
    public static partial class ListExtra
    {
        /// <summary>
        /// This list elements exclude other list elements
        /// </summary>
        /// <param name="thisList"></param>
        /// <param name="otherList"></param>
        /// <returns></returns>
        public static List<string> GetUniqueOfThis(this List<string> thisList, List<string> otherList)
        {
            return otherList.GetUniqueOfOther(thisList);
        }
    }
}