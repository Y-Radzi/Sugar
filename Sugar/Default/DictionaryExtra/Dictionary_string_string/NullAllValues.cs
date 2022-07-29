using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class DictionaryExtra
    {
        /// <summary>
        /// Nulls all values, but save keys
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static Dictionary<string, string> NullAllValues(this Dictionary<string, string> dictionary)
        {
            var keys = dictionary.Keys.ToList();
            foreach(var key in keys)
                dictionary[key] = null;

            return dictionary;
        }

    }
}
