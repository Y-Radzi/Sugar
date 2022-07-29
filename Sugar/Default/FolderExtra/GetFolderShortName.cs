using System.IO;

namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Get folder short name from folderFullName
        /// </summary>
        /// <param name="folderFullName"></param>
        /// <returns></returns>
        public static string GetFolderShortName(string folderFullName)
        {
            return FileExtra.GetFileShortNameWithExtention(folderFullName);
        }

    }
}
