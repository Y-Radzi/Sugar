using System.Collections.Generic;
using System.Linq;

namespace Sugar
{
    public static partial class IDictionaryExtra<TempKey, TempValue>
    {
        /// <summary>
        /// Sets value if key exists
        /// </summary>
        /// <param name="idictionary"></param>
        /// <param name="keyInput"></param>
        /// <param name="valueInput"></param>
        /// <returns></returns>
        public static IDictionary<TempKey, TempValue> SetValueIfKeyExists(IDictionary<TempKey, TempValue> idictionary, TempKey keyInput, TempValue valueInput)
        {
            var keys = idictionary.Keys.ToList();
            foreach(var key in keys)
                if (key.Equals(keyInput))
                    idictionary[key] = valueInput;

            return idictionary;
        }

    }
}
