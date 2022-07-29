using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class IDictionaryExtra<TempKey, TempValue>
    {
        /// <summary>
        /// Displays IDictionary's keys and values
        /// </summary>
        /// <param name="idictionary"></param>
        /// <param name="keySplitter">splitter between key and value</param>
        /// <param name="keyValuePairSplitter">splitter after value</param>
        /// <returns></returns>
        public static string Display(IDictionary<TempKey, TempValue> idictionary, string keySplitter, string keyValuePairSplitter)
        {
            string result = "";
            var keys = idictionary.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
                result += ((i == 0) ? "" : keyValuePairSplitter)
                    + keys[i]
                    + keySplitter
                    + ((idictionary[keys[i]] == null) ? "" : idictionary[keys[i]].ToString());
                
            return result;
        }

        /// <summary>
        /// Displays IDictionary's keys and values
        /// </summary>
        /// <param name="idictionary"></param>
        /// <returns></returns>
        public static string Display(IDictionary<TempKey, TempValue> idictionary)
        {
            return Display(idictionary, StringExtra.SplitterHeaderOfLineDefault, StringExtra.SplitterRowDefault);
        }
    }
}
