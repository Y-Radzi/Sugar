using System;
using System.Collections.Generic;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Is any file has extention of list
        /// </summary>
        /// <param name="filesFullName"></param>
        /// <param name="extentions">extentions without "."</param>
        /// <returns></returns>
        public static bool IsAnyFileHasExtention(List<string> filesFullName, List<string> extentions)
        {
            bool result = false;
            foreach (var file in filesFullName)
            {
                string extention = GetFileExtention(file).ToLower();
                if (!String.IsNullOrEmpty(extention))
                {
                    if (extentions.Contains(extention))
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

    }
}
