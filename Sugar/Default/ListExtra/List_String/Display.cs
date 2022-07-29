using System.Collections.Generic;

namespace Sugar
{
    public static partial class ListExtra
    {
        
        /// <summary>
        /// split + listName[i]: list[i]
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listName"></param>
        /// <param name="splitter"></param>
        /// <param name="isUseIndexes"></param>
        /// <returns></returns>
        public static string Display(this List<string> list, string listName, string splitter, bool isUseIndexes)
        {
            return ICollectionExtra<string>.Display(list, listName, splitter, isUseIndexes);
        }

        /// <summary>
        /// default_splitter + list[i]
        /// </summary>
        /// <param name="list"></param>
        /// <param name="listName"></param>
        /// <returns></returns>
        public static string Display(this List<string> list)
        {
            return ICollectionExtra<string>.Display(list);
        }
    }
}
