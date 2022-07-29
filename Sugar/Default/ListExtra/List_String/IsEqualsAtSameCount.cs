using System.Collections.Generic;

namespace Sugar
{
    public static partial class ListExtra
    {
        /// <summary>
        /// Is list equals to other at same indexes
        /// </summary>
        /// <param name="mainList"></param>
        /// <param name="otherList"></param>
        /// <returns></returns>
        public static bool IsEqualsAtSameCount(this List<string> mainList, List<string> otherList)
        {
            if (mainList == null && otherList == null)
                return true;

            if (mainList == null || otherList == null)
                return false;

            if (mainList.Equals(otherList))
                return true;

            int minCount = mainList.Count.GetMinimum(otherList.Count);

            for (int i = 0; i < minCount; i++)
                if (mainList[i] != otherList[i])
                    return false;

            return true;
        }

    }
}
