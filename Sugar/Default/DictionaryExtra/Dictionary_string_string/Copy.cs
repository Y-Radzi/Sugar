using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class DictionaryExtra
    {
        /// <summary>
        /// Copy dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static Dictionary<string, string> Copy(this Dictionary<string, string> dictionary)
        {
            var result = new Dictionary<string, string>();
            var keys = dictionary.Keys.ToList();
            foreach(var key in keys)
                result.Add(key, dictionary[key]);

            return result;
        }

    }
}
