using System.Collections.Generic;

namespace Sugar
{
    public static partial class IDictionaryExtra<TempKey, TempValue>
    {
        /// <summary>
        /// Is IDictionary null or empty
        /// </summary>
        /// <param name="idictionary"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(IDictionary<TempKey, TempValue> idictionary)
        {
            if (idictionary == null)
                return true;

            if (idictionary.Count == 0)
                return true;
            else
                return false;
        }

    }
}
