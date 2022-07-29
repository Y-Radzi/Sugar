using System.Collections.Generic;

namespace Sugar
{
    public static partial class DictionaryExtra
    {
        /// <summary>
        /// Is dictionary null or empty
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this Dictionary<string, string> dictionary)
        {
            return IDictionaryExtra<string, string>.IsNullOrEmpty(dictionary);
        }

    }
}
