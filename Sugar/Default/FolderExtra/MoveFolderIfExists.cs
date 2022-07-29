using System.IO;

namespace Sugar
{
    public static partial class FolderExtra
    {
        /// <summary>
        /// Moves directory with internals
        /// </summary>
        /// <param name="oldFolderFullName"></param>
        /// <param name="newFolderFullName"></param>
        /// <param name="isIgnoreIfNewNotEmpty"></param>
        /// <exception cref="System.Exception">if empty names; if not ignore new not empty, but new not empty</exception>
        public static void MoveFolderIfExists(string oldFolderFullName, string newFolderFullName, bool isIgnoreIfNewNotEmpty)
        {
            if (Directory.Exists(oldFolderFullName.ErrorIfEmpty("MoveIfExists", "oldFolderFullName")))
            {
                if (!IsFolder(oldFolderFullName, false))
                    throw new System.Exception($"Can't move {oldFolderFullName}, oldFolderFullName is not a folder");

                if (!Directory.Exists(newFolderFullName.ErrorIfEmpty("MoveIfExists", "newFolderFullName")))
                    Directory.CreateDirectory(newFolderFullName);

                if (!IsFolderEmpty(newFolderFullName) && !isIgnoreIfNewNotEmpty)
                    throw new System.Exception($"can't move {oldFolderFullName}: newFolderFullName is not empty, {newFolderFullName}");

                Directory.Move(oldFolderFullName, newFolderFullName);
            }
        }
    }
}
