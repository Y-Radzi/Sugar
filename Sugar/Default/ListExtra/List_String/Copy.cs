using System.Collections.Generic;

namespace Sugar
{
    public static partial class ListExtra
    {
        /// <summary>
        /// Get copy of this list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<string> Copy(this List<string> list)
        {
            var result = new List<string>();
            foreach(var element in list)
                result.Add(element);
            return result;
        }

    }
}
