using System.Collections.Generic;

namespace Sugar
{
    public static partial class DictionaryExtra
    {
        /// <summary>
        /// Displays dictionary's keys and values
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="keySplitter">splitter between key and value</param>
        /// <param name="keyValuePairSplitter">splitter after value</param>
        /// <returns></returns>
        public static string Display(this Dictionary<string, string> dictionary, string keySplitter, string keyValuePairSplitter)
        {
            return IDictionaryExtra<string, string>.Display(dictionary, keySplitter, keyValuePairSplitter);
        }

        /// <summary>
        /// Displays dictionary's keys and values
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static string Display(this Dictionary<string, string> dictionary)
        {
            return IDictionaryExtra<string, string>.Display(dictionary);
        }
    }
}
