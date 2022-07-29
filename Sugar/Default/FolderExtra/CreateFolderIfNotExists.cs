using System.IO;

namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Creates new folder if not exists
        /// </summary>
        /// <param name="folderFullName"></param>
        public static void CreateFolderIfNotExists(string folderFullName)
        {
            if (!Directory.Exists(folderFullName.ErrorIfEmpty("CreateIfNotExists", "folderFullName")))
                Directory.CreateDirectory(folderFullName);
        }
    }
}
