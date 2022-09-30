using System.IO;

namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Is folder not contains something
        /// </summary>
        /// <param name="folderFullName"></param>
        /// <returns>false if contains or not exists, else: true</returns>
        /// <exception cref="System.Exception">if name folderFullName empty</exception>
        public static bool IsFolderEmpty(string folderFullName)
        {
            if (!Directory.Exists(folderFullName.ErrorIfEmpty("IsEmpty", "folderFullName")))
                return false;

            if (!IsFolder(folderFullName, false))
                throw new System.Exception($"Can't \"IsFolderEmpty\" {folderFullName}, folderFullName is not a folder");

            var childFolders = Directory.GetDirectories(folderFullName, "*", SearchOption.AllDirectories);
            var childFiles = Directory.GetFiles(folderFullName, "*.*", SearchOption.AllDirectories);

            if (Array<string>.IsNullOrEmpty(childFolders) && Array<string>.IsNullOrEmpty(childFiles))
                return true;
            else
                return false;
        }
    }
}