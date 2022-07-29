using System.Collections.Generic;

namespace Sugar
{
    public static partial class ListExtra
    {
        /// <summary>
        /// Get intersected elements
        /// </summary>
        /// <param name="thisList"></param>
        /// <param name="otherList"></param>
        /// <returns></returns>
        public static List<string> GetIntersection(this List<string> thisList, List<string> otherList)
        {
            List<string> result = new List<string>();

            foreach (var otherElement in otherList)
                if (thisList.Contains(otherElement))
                    result.Add(otherElement.ToString());

            return result;
        }
    }
}