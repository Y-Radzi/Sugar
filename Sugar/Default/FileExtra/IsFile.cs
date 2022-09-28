using System.IO;
using System.Collections.Generic;

namespace Sugar
{
    public static partial class FileExtra
    {
        /// <summary>
        /// Checking existing element: is file or folder?
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <param name="isExceptionIfNotExists"></param>
        /// <returns>"true" if file, "false" if not or not exists, or exception if isExeptionIfNotExists</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool IsFile(string fileFullName, bool isExceptionIfNotExists)
        {
            if (File.Exists(fileFullName.ErrorIfEmpty("IsFile", "fileFullName")))
            {
                FileAttributes attr = File.GetAttributes(fileFullName);
                if (attr.HasFlag(FileAttributes.Directory))
                    return false;
                else
                    return true;
            }
            else if (isExceptionIfNotExists)
                throw new System.Exception($"Can't check \"IsFile\", file not exists: {fileFullName}");
            else
                return false;

        }

        public static bool IsFiles(List<string> filesFullName, bool isExceptionIfNotExists)
        {
            foreach (var fileFullName in filesFullName)
            {
                if (!IsFile(fileFullName, isExceptionIfNotExists))
                    return false;
            }

            return true;
        }
    }
}
