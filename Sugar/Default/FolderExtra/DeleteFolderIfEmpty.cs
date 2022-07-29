using System.IO;

namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Delete folder if it exists and empty
        /// </summary>
        /// <param name="folderFullName"></param>
        public static void DeleteFolderIfEmpty(string folderFullName)
        {
            if (Directory.Exists(folderFullName.ErrorIfEmpty("DeleteIfExistsEmpty", "folderFullName")))
                if (IsFolderEmpty(folderFullName))
                    Directory.Delete(folderFullName);
        }
    }
}
