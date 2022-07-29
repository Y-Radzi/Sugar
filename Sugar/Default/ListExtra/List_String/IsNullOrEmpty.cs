using System.Collections.Generic;

namespace Sugar
{
    public static partial class ListExtra
    {
        /// <summary>
        /// Is collection null or empty
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this List<string> list)
        {
            return ICollectionExtra<string>.IsNullOrEmpty(list);
        }
    }
}