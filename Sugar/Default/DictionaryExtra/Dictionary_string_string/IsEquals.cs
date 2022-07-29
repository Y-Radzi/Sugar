using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class DictionaryExtra
    {

        /// <summary>
        /// Compares dictionaries with keys and values
        /// </summary>
        /// <param name="thisDictionary"></param>
        /// <param name="otherDictionary"></param>
        /// <returns></returns>
        public static bool IsEquals(this Dictionary<string, string> thisDictionary, Dictionary<string, string> otherDictionary)
        {
            return IDictionaryExtra<string, string>.IsEquals(thisDictionary, otherDictionary);
        }

    }
}
