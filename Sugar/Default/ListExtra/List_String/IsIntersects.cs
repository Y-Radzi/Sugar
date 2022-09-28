using System.Collections.Generic;

namespace Sugar
{
    public static partial class ListExtra
    {
        /// <summary>
        /// Is any elements of list equals to any elements of other
        /// </summary>
        /// <param name="thisList"></param>
        /// <param name="otherList"></param>
        /// <returns></returns>
        public static bool IsIntersects(this List<string> thisList, List<string> otherList)
        {
           foreach (var otherElement in otherList)
                if (thisList.Contains(otherElement))
                    return true;

            return false;
        }
    }
}