using System.Collections.Generic;

namespace Sugar
{
    public static partial class ICollectionExtra<Temp>
    {
        /// <summary>
        /// split + name[i]: element of collection
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="name"></param>
        /// <param name="splitter"></param>
        /// <param name="isUseIndexes"></param>
        /// <returns></returns>
        public static string Display(ICollection<Temp> collection, string name, string splitter, bool isUseIndexes)
        {
            if (collection == null)
                return "";

            if (name == null)
                name = "";

            string splitterIndexData = (name != "" || isUseIndexes) ? StringExtra.SplitterHeaderOfLineDefault : "";

            string result = "";
            int index = 0;
            foreach (var element in collection)
            {
                result += ((index != 0) ? splitter : "")
                    + name
                    + ((isUseIndexes) ? $"[{index}]" : "")
                    + splitterIndexData
                    + ((element == null) ? "" : element.ToString());

                index++;
            }

            return result;
        }

        /// <summary>
        /// default_splitter + element
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static string Display(ICollection<Temp> collection)
        {
            return Display(collection, "", StringExtra.SplitterRowDefault, false);
        }
    }
}
