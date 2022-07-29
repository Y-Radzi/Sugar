using System.Collections.Generic;

namespace Sugar
{
    public static partial class ICollectionExtra<Temp>
    {
        /// <summary>
        /// Is collection null or empty
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(ICollection<Temp> collection)
        {
            if (collection == null)
                return true;

            if (collection.Count == 0)
                return true;
            else
                return false;
        }
    }
}