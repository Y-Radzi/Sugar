using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class DictionaryExtra
    {
        /// <summary>
        /// Sets value if key exists
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="keyInput"></param>
        /// <param name="valueInput"></param>
        /// <returns></returns>
        public static Dictionary<string, string> SetValueIfKeyExists(this Dictionary<string, string> dictionary, string keyInput, string valueInput)
        {
            var keys = dictionary.Keys.ToList();
            foreach(var key in keys)
                if (key == keyInput)
                    dictionary[key] = valueInput;

            return dictionary;
        }

    }
}
