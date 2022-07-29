using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class IDictionaryExtra<TempKey, TempValue>
    {
        /// <summary>
        /// Compares IDictionaries with keys and values
        /// </summary>
        /// <param name="thisIDictionary"></param>
        /// <param name="otherIDictionary"></param>
        /// <returns></returns>
        public static bool IsEquals(IDictionary<TempKey, TempValue> thisIDictionary, IDictionary<TempKey, TempValue> otherIDictionary)
        {
            bool isThisEmpty = IsNullOrEmpty(thisIDictionary);
            bool isOtherEmpty = IsNullOrEmpty(otherIDictionary);

            if (isThisEmpty && isOtherEmpty)
                return true;
            else if (isThisEmpty != isOtherEmpty)
                return false;
            else
            {
                var thisKeys = thisIDictionary.Keys.ToList();
                var otherKeys = otherIDictionary.Keys.ToList();

                if (thisKeys.Count != otherKeys.Count)
                    return false;

                foreach (var thisKey in thisKeys)
                {
                    if (!otherKeys.Contains(thisKey))
                        return false;
                    else if (!otherIDictionary[thisKey].EqualsSafe(thisIDictionary[thisKey]))
                        return false;
                }

                return true;
            }
        }

    }
}
