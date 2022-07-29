using System.IO;

namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Checking existing element: is file or folder?
        /// </summary>
        /// <param name="folderFullName"></param>
        /// <param name="isExceptionIfNotExists"></param>
        /// <returns>"true" if folder, "false" if not or not exists, or exception if isExeptionIfNotExists</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool IsFolder(string folderFullName, bool isExceptionIfNotExists)
        {
            if (Directory.Exists(folderFullName.ErrorIfEmpty("IsFolder", "folderFullName")))
            {
                FileAttributes attr = File.GetAttributes(folderFullName);
                if (attr.HasFlag(FileAttributes.Directory))
                    return true;
                else
                    return false;
            }
            else if (isExceptionIfNotExists)
                throw new System.Exception($"Can't check \"IsFolder\", element not exists: {folderFullName}");
            else
                return false;

        }
    }
}
